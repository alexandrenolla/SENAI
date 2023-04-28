using Microsoft.AspNetCore.Mvc;
using ex5.Models;
using ex5.Repositories.Interfaces;
using ex5.Dtos;

namespace ex5.Controllers;

[ApiController]
//[Route("[controller]")]
public class StudentController : ControllerBase
{   
    // Injeção de dependência do repositório
    private readonly IStudentRepository _studentRepository;

    public StudentController(IStudentRepository studentrepository)
    {
        _studentRepository = studentrepository;
    }

    [HttpGet]
    [Route("api/obter/{id}")]
    public IActionResult ObterId(int id)
    {
        var student = _studentRepository.ObterPorId(id);
        if(student == null)
        {
            return NotFound("Id de aluno inexistente nos registros do banco de dados.");
        }
        else
        {
            return Ok(student);
        }
    }

    [HttpGet]
    [Route("api/listar")]
    public IActionResult ObterLista()
    {
        var students = _studentRepository.Listar();

        return Ok(students);
    }

    [HttpPost]
    [Route("api/criar")]
    public IActionResult Criar([FromBody] StudentCriarDto studentDto)
    {
        var newStudent = new Student();
        newStudent.Period = studentDto.Period;
        newStudent.RA = studentDto.RA;

        _studentRepository.Criar(newStudent);

        return CreatedAtAction(nameof(StudentController.ObterId), new {id = newStudent.Id}, studentDto);
    }

    [HttpPut]
    [Route("api/atualizar/{id}")]
    public IActionResult Atualizar(int id, [FromBody] StudentAtualizarDto studentDto)
    {
        var updatestudent = _studentRepository.ObterPorId(id);
        if(updatestudent == null)
        {
            return NotFound("Id de aluno inexistente nos registros do banco de dados.");
        }
        else
        {
            updatestudent.Period = studentDto.Period;
            updatestudent.RA = studentDto.RA;

            _studentRepository.Atualizar(updatestudent);

            return CreatedAtAction(nameof(StudentController.ObterId), new {id = updatestudent.Id}, studentDto);
        }
    }

    [HttpDelete]
    [Route("api/deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        if(_studentRepository.Excluir(id))
        {
            return NoContent();
        }
        else
        {
            return NotFound("Id de aluno inexistente nos registros do banco de dados.");
        }
    }
}