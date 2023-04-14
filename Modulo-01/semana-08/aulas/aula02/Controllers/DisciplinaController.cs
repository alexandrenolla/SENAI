using Microsoft.AspNetCore.Mvc;
using aula02.Repositories;
using aula02.Dtos;
namespace aula02.Controllers;

[ApiController]
[Route("[controller]")] //endpoint
public class DisciplinaController : ControllerBase
{   
    
    [HttpGet] // verbo http
    [Route("listar")]
    public IActionResult Listar([FromQuery]string? nome) // Query String opcional por conta da ? na frente do tipo no parâmetro.
    {   
        var repository = new DisciplinaRepository();
        var disciplinas = repository.ListarDisciplina(nome);

        return Ok(disciplinas);
    }

    [HttpGet] // Verbo para obter dados
    [Route("{id}")] // Path
    // O Route com {} significa receber o valor, no caso id, como parâmetro para a busca direta pelo valor.
    public IActionResult Obter ([FromRoute]int id)
    {
        if(id <= 0)
        {
            return BadRequest("id deve ser maior que zero"); // Validação com status code
        }

        var repository = new DisciplinaRepository();
        var disciplina = repository.ObterDisciplina(id);

        if(disciplina == null)
        {
            return NotFound(); // Validação com status code
        }
        return Ok(disciplina);
    }

    [HttpPost]
    public IActionResult Criar([FromBody] DisciplinaDto dto)
    {
        var repository = new DisciplinaRepository();
        var disciplina = repository.CriarDisciplina(dto);
        return CreatedAtAction(nameof(DisciplinaController.Obter), new { id = disciplina.Id }, disciplina);
    }

    [HttpPatch] // Verbo para atualizar o objeto parcialmente
    [Route("{id}")] // Path
    public IActionResult Atualizar (int id, [FromForm] DisciplinaDto dto) // id do objeto a ser atualizado e o novo objeto
    {   
        var repository = new DisciplinaRepository();
        var disciplina = repository.AtualizarDisciplina(id, dto);
        return Ok(disciplina);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Excluir (int id)
    {
        var repository = new DisciplinaRepository();
        repository.DeletarDisciplina(id);
        
        return NoContent(); 
    }
    // dúvida1: como essa dto se conecta com a classe dos modelos?
    // dúvida2: pq no método Criar ele usou ".Obter" no nameof?
    // dúvida2.1: oq ele quis dizer com new id = disciplina.Id?
}