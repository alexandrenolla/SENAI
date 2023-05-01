using Microsoft.AspNetCore.Mvc;
using ex5.Models;
using ex5.Repositories.Interfaces;
using ex5.Dtos;

namespace ex5.Controllers;


[ApiController]
//[Route("[controller]")]
public class TeacherController : ControllerBase
{   
    // Injeção de dependência do repositório
    private readonly ITeacherRepository _teacherRepository;

    public TeacherController(ITeacherRepository studentrepository)
    {
        _teacherRepository = studentrepository;
    }

    [HttpGet]
    [Route("api/teacher/obter/{id}")]
    public IActionResult ObterId(int id)
    {
        var teacher = _teacherRepository.ObterPorId(id);
        if(teacher == null)
        {
            return NotFound("Id de aluno inexistente nos registros do banco de dados.");
        }
        else
        {
            return Ok(teacher);
        }
    }

    [HttpGet]
    [Route("api/teachers/listar")]
    public IActionResult ObterLista()
    {
        var teachers = _teacherRepository.Listar();

        return Ok(teachers);
    }

    [HttpPost]
    [Route("api/teacher/criar")]
    public IActionResult Criar([FromBody] TeacherCriarDto teacherDto)
    {
        var newTeacher = new Teacher();
        newTeacher.Department = teacherDto.Department;

        _teacherRepository.Criar(newTeacher);

        return CreatedAtAction(nameof(StudentController.ObterId), new {id = newTeacher.Id}, teacherDto);
    }

    [HttpPut]
    [Route("api/teacher/atualizar/{id}")]
    public IActionResult Atualizar(int id, [FromBody] TeacherAtualizarDto teacherDto)
    {
        var updateteacher = _teacherRepository.ObterPorId(id);
        if(updateteacher == null)
        {
            return NotFound("Id de professor inexistente nos registros do banco de dados.");
        }
        else
        {
            updateteacher.Department = teacherDto.Department;

            _teacherRepository.Atualizar(updateteacher);

            return CreatedAtAction(nameof(StudentController.ObterId), new {id = updateteacher.Id}, teacherDto);
        }
    }

    [HttpDelete]
    [Route("api/teacher/deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        if(_teacherRepository.Excluir(id))
        {
            return NoContent();
        }
        else
        {
            return NotFound("Id de professor inexistente nos registros do banco de dados.");
        }
    }
}