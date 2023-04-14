using ex8.Repositories;
using ex8.Models;
using Microsoft.AspNetCore.Mvc;

namespace ex8.Controller;

[ApiController]
[Route("[controler]")]
public class AlunoController : ControllerBase
{
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar([FromQuery] string? nome)
    {
        var repository = new AlunosRepository();
        var lista = repository.ListarAluno(nome);
        
        return Ok(lista);
    }
}