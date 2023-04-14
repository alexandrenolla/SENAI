using ex11.Repositories;
using ex11.Models;
using ex11.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ex11.Controller;

[ApiController]
[Route("[controler]")]
public class AlunoController : ControllerBase
{
    [HttpGet]
    [Route("Listar")]
    public IActionResult Listar([FromQuery] string? nome)
    {
        var repository = new AlunosRepository();
        var lista = repository.ListarAluno(nome);
        
        return Ok(lista);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Obter ([FromRoute] int id)
    {   
        var repository = new AlunosRepository();
        var aluno = repository.ObterAluno(id);
        if(aluno == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(aluno);
        } 
    }

    [HttpPost]
    [Route("Criar")]
    public IActionResult Criar ([FromBody] CriacaoAlunoDto dto)
    {
        var repository = new AlunosRepository();
        var aluno = repository.CriarAluno(dto);

        return CreatedAtAction(nameof(AlunoController.Obter), new { id = aluno.Id}, aluno);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Deletar ([FromRoute] int id)
    {
        var repository = new AlunosRepository();
        repository.ExcluirAluno(id);
        
        return NoContent();
    }
}