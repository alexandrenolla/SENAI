using ex10.Repositories;
using ex10.Models;
using ex10.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ex10.Controller;

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
}