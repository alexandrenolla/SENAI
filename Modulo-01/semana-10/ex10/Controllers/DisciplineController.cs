using Microsoft.AspNetCore.Mvc;
using ex5.Models;
using ex5.Repositories.Interfaces;
using ex5.Dtos;

namespace ex5.Controllers;

[ApiController]
//[Route("[controller]")]
public class DisciplineController : ControllerBase
{   
    // Injeção de dependência do repositório
    private readonly IDisciplineRepository _disciplineRepository;

    public DisciplineController(IDisciplineRepository disciplinerepository)
    {
        _disciplineRepository = disciplinerepository;
    }

    [HttpGet]
    [Route("api/discipline/obter/{id}")]
    public IActionResult ObterId(int id)
    {
        var discipline = _disciplineRepository.ObterPorId(id);
        if(discipline == null)
        {
            return NotFound("Id de disciplina inexistente nos registros do banco de dados.");
        }
        else
        {
            return Ok(discipline);
        }
    }

    [HttpGet]
    [Route("api/disciplines/listar")]
    public IActionResult ObterLista()
    {
        var disciplines = _disciplineRepository.Listar();

        return Ok(disciplines);
    }

    [HttpPost]
    [Route("api/discipline/criar")]
    public IActionResult Criar([FromBody] DisciplineDto disciplineDto)
    {
        var discipline = new Discipline();
        discipline.DisciplineName = disciplineDto.DisciplineName;
    

        _disciplineRepository.Criar(discipline);

        return CreatedAtAction(nameof(StudentController.ObterId), new {id = discipline.Id}, disciplineDto);
    }

    [HttpPut]
    [Route("api/discipline/atualizar/{id}")]
    public IActionResult Atualizar(int id, [FromBody] DisciplineDto disciplineDto)
    {
        var discipline = _disciplineRepository.ObterPorId(id);
        if(discipline == null)
        {
            return NotFound("Id de disciplina inexistente nos registros do banco de dados.");
        }
        else
        {
            discipline.DisciplineName = disciplineDto
            .DisciplineName;

            _disciplineRepository.Atualizar(discipline);

            return CreatedAtAction(nameof(StudentController.ObterId), new {id = discipline.Id}, disciplineDto);
        }
    }

    [HttpDelete]
    [Route("api/discipline/deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        if(_disciplineRepository.Excluir(id))
        {
            return NoContent();
        }
        else
        {
            return NotFound("Id de disciplina inexistente nos registros do banco de dados.");
        }
    }
}