using Microsoft.AspNetCore.Mvc;
using ex5.Models;
using ex5.Repositories.Interfaces;
using ex5.Dtos;

namespace ex5.Controllers;

[ApiController]
//[Route("[controller]")]
public class StudentDisciplineController : ControllerBase
{   
    // Injeção de dependência do repositório
    private readonly IStudentDisciplineRepository _studentDisciplineRepository;

    public StudentDisciplineController(IStudentDisciplineRepository studentDisciplinerepository)
    {
        _studentDisciplineRepository = studentDisciplinerepository;
    }

    [HttpGet]
    [Route("api/obter/{id}")]
    public IActionResult ObterId(int id)
    {
        var studentDiscipline = _studentDisciplineRepository.ObterPorId(id);
        if(studentDiscipline == null)
        {
            return NotFound("Id de Estudante/Disciplina inexistente nos registros do banco de dados.");
        }
        else
        {
            return Ok(studentDiscipline);
        }
    }

    [HttpGet]
    [Route("api/listar")]
    public IActionResult ObterLista()
    {
        var studentDisciplines = _studentDisciplineRepository.Listar();

        return Ok(studentDisciplines);
    }

    [HttpPost]
    [Route("api/criar")]
    public IActionResult Criar([FromBody] StudentDisciplineDto studentDisciplineDto)
    {
        var studentDiscipline = new StudentDiscipline();
        studentDiscipline.Discipline = studentDisciplineDto;
        studentDiscipline.Student = studentDisciplineDto;
        

        _studentDisciplineRepository.Criar(studentDiscipline);

        return CreatedAtAction(nameof(StudentController.ObterId), new {id = studentDiscipline.Id}, studentDisciplineDto);
    }

    [HttpPut]
    [Route("api/atualizar/{id}")]
    public IActionResult Atualizar(int id, [FromBody] StudentDisciplineDto studentDisciplineDto)
    {
        var studentDiscipline = _studentDisciplineRepository.ObterPorId(id);
        if(studentDiscipline == null)
        {
            return NotFound("Id de Estudante/Disciplina inexistente nos registros do banco de dados.");
        }
        else
        {
            studentDiscipline.Discipline = studentDisciplineDto;

            _studentDisciplineRepository.Atualizar(studentDiscipline);

            return CreatedAtAction(nameof(StudentController.ObterId), new {id = studentDiscipline.Id}, studentDisciplineDto);
        }
    }

    [HttpDelete]
    [Route("api/deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        if(_studentDisciplineRepository.Excluir(id))
        {
            return NoContent();
        }
        else
        {
            return NotFound("Id de Estudante/Disciplina inexistente nos registros do banco de dados.");
        }
    }
}