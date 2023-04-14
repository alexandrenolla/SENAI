using System.Linq;
using ex6.Models;
namespace ex6.Repositories;

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
}