using Microsoft.AspNetCore.Mvc;
using aulas.Models;
namespace aulas.Controllers;


[ApiController] //Indicar que classe é um controller
[Route("[controller]")] // Customização da url
public class AlunoController : ControllerBase
{   
    [HttpGet]
    [Route("ObterAlunos")]
    public IActionResult ObterAlunos()
    {
        var aluno = new Aluno();
        aluno.Id = 1;
        aluno.Nome = "João";
        aluno.DataDeNascimento = new DateTime(1991,10,10);

        return Ok(aluno);
    }

    [HttpGet]
    [Route("ObterAluno")]
    public IActionResult ObterAluno()
    {
        var aluno2 = new Aluno();
        aluno2.Id = 1;
        aluno2.Nome = "Gabriel";
        aluno2.DataDeNascimento = new DateTime(1991,10,10);
        return Ok(aluno2);
    }
}