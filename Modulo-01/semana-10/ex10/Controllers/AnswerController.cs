using Microsoft.AspNetCore.Mvc;
using ex5.Models;
using ex5.Repositories.Interfaces;
using ex5.Dtos;

namespace ex5.Controllers;


[ApiController]
//[Route("[controller]")]
public class AnswerController : ControllerBase
{   
    // Injeção de dependência do repositório
    private readonly IAnswerRepository _answerRepository;

    public AnswerController(IAnswerRepository answerrepository)
    {
        _answerRepository = answerrepository;
    }

    [HttpGet]
    [Route("api/obter/{id}")]
    public IActionResult ObterId(int id)
    {
        var answer = _answerRepository.ObterPorId(id);
        if(answer == null)
        {
            return NotFound("Id de answer inexistente nos registros do banco de dados.");
        }
        else
        {
            return Ok(answer);
        }
    }

    [HttpGet]
    [Route("api/listar")]
    public IActionResult ObterLista()
    {
        var answers = _answerRepository.Listar();

        return Ok(answers);
    }

    [HttpPost]
    [Route("api/criar")]
    public IActionResult Criar([FromBody] AnswerCriarDto answerDto)
    {
        var answer = new Answer();
        answer.Score = answerDto.Score;
        answer.Observation = answerDto.Observation;
        
        _answerRepository.Criar(answer);

        return CreatedAtAction(nameof(StudentController.ObterId), new {id = answer.Id}, answerDto);
    }

    [HttpPut]
    [Route("api/atualizar/{id}")]
    public IActionResult Atualizar(int id, [FromBody] AnswerAtualizarDto answerDto)
    {
        var answer = _answerRepository.ObterPorId(id);
        if(answer == null)
        {
            return NotFound("Id de answer inexistente nos registros do banco de dados.");
        }
        else
        {
            answer.Score = answerDto.Score;
            answer.Observation = answerDto.Observation;

            _answerRepository.Atualizar(answer);

            return CreatedAtAction(nameof(StudentController.ObterId), new {id = answer.Id}, answerDto);
        }
    }

    [HttpDelete]
    [Route("api/deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        if(_answerRepository.Excluir(id))
        {
            return NoContent();
        }
        else
        {
            return NotFound("Id de answer inexistente nos registros do banco de dados.");
        }
    }
}