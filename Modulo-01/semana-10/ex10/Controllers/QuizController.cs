using Microsoft.AspNetCore.Mvc;
using ex5.Models;
using ex5.Repositories.Interfaces;
using ex5.Dtos;

namespace ex5.Controllers;


[ApiController]
//[Route("[controller]")]
public class QuizController : ControllerBase
{   
    // Injeção de dependência do repositório
    private readonly IQuizRepository _quizRepository;

    public QuizController(IQuizRepository quizrepository)
    {
        _quizRepository = quizrepository;
    }

    [HttpGet]
    [Route("api/obter/{id}")]
    public IActionResult ObterId(int id)
    {
        var quiz = _quizRepository.ObterPorId(id);
        if(quiz == null)
        {
            return NotFound("Id de quiz inexistente nos registros do banco de dados.");
        }
        else
        {
            return Ok(quiz);
        }
    }

    [HttpGet]
    [Route("api/listar")]
    public IActionResult ObterLista()
    {
        var quizzes = _quizRepository.Listar();

        return Ok(quizzes);
    }

    [HttpPost]
    [Route("api/criar")]
    public IActionResult Criar([FromBody] QuizCriarDto quizDto)
    {
        var quiz = new Quiz();
        quiz.Title = quizDto.Title;
        quiz.DateOpen = quizDto.DateOpen;
        quiz.DateClose = quizDto.DateClose;

        _quizRepository.Criar(quiz);

        return CreatedAtAction(nameof(StudentController.ObterId), new {id = quiz.Id}, quizDto);
    }

    [HttpPut]
    [Route("api/atualizar/{id}")]
    public IActionResult Atualizar(int id, [FromBody] QuizAtualizarDto quizDto)
    {
        var quiz = _quizRepository.ObterPorId(id);
        if(quiz == null)
        {
            return NotFound("Id de quiz inexistente nos registros do banco de dados.");
        }
        else
        {
            quiz.Title = quizDto.Title;
            quiz.DateOpen = quizDto.DateOpen;
            quiz.DateClose = quizDto.DateClose;

            _quizRepository.Atualizar(quiz);

            return CreatedAtAction(nameof(StudentController.ObterId), new {id = quiz.Id}, quizDto);
        }
    }

    [HttpDelete]
    [Route("api/deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        if(_quizRepository.Excluir(id))
        {
            return NoContent();
        }
        else
        {
            return NotFound("Id de quiz inexistente nos registros do banco de dados.");
        }
    }
}