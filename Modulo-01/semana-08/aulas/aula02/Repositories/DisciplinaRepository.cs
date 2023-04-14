// Design Pattern: Classe responsável pelas operações de banco
using aula02.Models;
using aula02.Dtos;
using static aula02.Controllers.DisciplinaController;

namespace aula02.Repositories;

public class DisciplinaRepository {
    private static List<Disciplina> lista = new List<Disciplina>()
    { 
        new Disciplina { Id = 1, CargaHoraria = 20, Nome = "História" },
        new Disciplina { Id = 2, CargaHoraria = 20, Nome = "História do Brasil" },
        new Disciplina { Id = 3, CargaHoraria = 20, Nome = "História Geral" },
        new Disciplina { Id = 4, CargaHoraria = 20, Nome = "Matemática" }
    };

    public List<Disciplina> ListarDisciplina(string? filtroNome)
    {   
        if(string.IsNullOrEmpty(filtroNome))
        {
            return lista;
        }
        else
        {
            return lista.Where(x => x.Nome.ToLower().Contains(filtroNome.ToLower())).OrderBy(x => x.Id).ToList(); // Linq (where) + Lambada (x => x)
        } 
        // Linq é somente para collections!
        // Comandos Linq de condição mais utilizados: Where, FirstOrDefault, Any, All.
        // Agrupamento: GroupBy
        // Ordenamento: OrderBy
    }

    public Disciplina? ObterDisciplina(int id)
    {
        return lista.FirstOrDefault(x => x.Id == id); // FirstOrDefault: Retorna o primeiro valor encontrado ou retorna nulo se não achar.
    }

    public Disciplina AtualizarDisciplina(int id, DisciplinaDto dto)
    {
        var disciplina = ObterDisciplina(id);
        lista.Remove(disciplina);

        disciplina.CargaHoraria = dto.CargaHoraria > 0 ? dto.CargaHoraria : disciplina.CargaHoraria; // Op. Ternário validando a carga horária ser maior que 0.
        disciplina.Nome = dto.Nome;
        disciplina.DataDaAlteracao = DateTime.Now;

        lista.Add(disciplina);

        return disciplina;
    }

    public Disciplina CriarDisciplina(DisciplinaDto dto)
    {
        var disciplina = new Disciplina();
        disciplina.Id = GerarId();
        disciplina.CargaHoraria = dto.CargaHoraria;
        disciplina.Nome = dto.Nome;
        disciplina.DataDaInclusao = DateTime.Now;

        lista.Add(disciplina);

        return disciplina;
    }

    private int GerarId()
    {
        return lista.Last().Id + 1;
    }

    public void DeletarDisciplina(int id)
    {
        var disciplina = lista.FirstOrDefault(x => x.Id == id);
        if (disciplina != null)
        {
            lista.Remove(disciplina);
        }
    }
}