using System.Linq;
using ex8.Models;
namespace ex8.Repositories;

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