using Microsoft.AspNetCore.Mvc;
using ex5.Models;
using ex5.Repositories.Interfaces;
using ex5.Dtos;

namespace ex5.Controllers;


[ApiController]
//[Route("[controller]")]
public class QuestionController : ControllerBase
{   
    // Injeção de dependência do repositório
    private readonly IQuestionRepository _questionRepository;

    public QuestionController(IQuestionRepository questionrepository)
    {
        _questionRepository = questionrepository;
    }

    [HttpGet]
    [Route("api/obter/{id}")]
    public IActionResult ObterId(int id)
    {
        var question = _questionRepository.ObterPorId(id);
        if(question == null)
        {
            return NotFound("Id de question inexistente nos registros do banco de dados.");
        }
        else
        {
            return Ok(question);
        }
    }

    [HttpGet]
    [Route("api/listar")]
    public IActionResult ObterLista()
    {
        var questions = _questionRepository.Listar();

        return Ok(questions);
    }

    [HttpPost]
    [Route("api/criar")]
    public IActionResult Criar([FromBody] QuestionDto questionDto)
    {
        var question = new Question();
        question.Enunciation = questionDto.Enunciation;
        question.Weight = questionDto.Weight;
        
        _questionRepository.Criar(question);

        return CreatedAtAction(nameof(StudentController.ObterId), new {id = question.Id}, questionDto);
    }

    [HttpPut]
    [Route("api/atualizar/{id}")]
    public IActionResult Atualizar(int id, [FromBody] QuestionDto questionDto)
    {
        var question = _questionRepository.ObterPorId(id);
        if(question == null)
        {
            return NotFound("Id de question inexistente nos registros do banco de dados.");
        }
        else
        {
            question.Enunciation = questionDto.Enunciation;
            question.Weight = questionDto.Weight;

            _questionRepository.Atualizar(question);

            return CreatedAtAction(nameof(StudentController.ObterId), new {id = question.Id}, questionDto);
        }
    }

    [HttpDelete]
    [Route("api/deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        if(_questionRepository.Excluir(id))
        {
            return NoContent();
        }
        else
        {
            return NotFound("Id de question inexistente nos registros do banco de dados.");
        }
    }
}