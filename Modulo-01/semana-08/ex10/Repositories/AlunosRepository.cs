using System.Linq;
using ex10.Models;
using ex10.Dtos;
namespace ex10.Repositories;

public class AlunosRepository
{
    private static List<AlunoModel> lista = new List<AlunoModel>();

    public List<AlunoModel> ListarAluno(string? nome)
    {
        if(string.IsNullOrEmpty(nome))
        {
            return lista;
        }
        else
        {
            return lista.Where(x => x.Nome.ToLower().Contains(nome.ToLower())).ToList(); 
        }    
    } 

    public AlunoModel? ObterAluno(int id)
    {
        return lista.FirstOrDefault(x => x.Id == id);
    }

    public AlunoModel CriarAluno(CriacaoAlunoDto dto)
    {
        var aluno = new AlunoModel();
        aluno.Id = GerarId();
        aluno.Nome = dto.Nome;
        aluno.DataDeNascimento = dto.DataDeNascimento;
        
        lista.Add(aluno);
        return aluno;
        
    }

    private int GerarId()
    {
        return lista.Last().Id + 1;
    }
}