using Microsoft.AspNetCore.Mvc;
namespace aula01.Controllers;


[ApiController] //Indicação que classe é uma controller
[Route("[controller]")] // customização da url (por padrão pega o prefixo da controller: Aluno)
public class AlunoController : ControllerBase // herda todas as funcionalidades de uma controller
{

    [HttpGet] // EndPoint de buscar dados
    [Route("obter-alunos")]
    public IActionResult ObterAlunos()
    {

        var lista = new List<Aluno>();

        var aluno = new Aluno();
        aluno.Id = 1;
        aluno.Nome = "João";
        aluno.DataNascimento = new DateTime(1990,10,10);

        var aluno2 = new Aluno();
        aluno2.Id = 2;
        aluno2.Nome = "Ana";
        aluno2.DataNascimento = new DateTime(2000,10,10);

        lista.Add(aluno);
        lista.Add(aluno2);

        return Ok(lista); //Retorna o ActionResult com status code 200 (indica sucesso).
    }
}