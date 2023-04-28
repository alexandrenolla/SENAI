using ex5.Context;
using ex5.Models;
using ex5.Repositories.Interfaces;

namespace ex5.Repositories;

public class DisciplineRepository : IDisciplineRepository
{   
    // Injeção de dependência do Context
    private readonly Contexto _context;

    // Assinatura
    public DisciplineRepository (Contexto context)
    {
        _context = context;
    }

    public void Atualizar(Discipline discipline)
    {
        _context.Disciplines.Update(discipline);
        _context.SaveChanges();
    }

    public void Criar(Discipline discipline)
    {
        _context.Disciplines.Add(discipline);
        _context.SaveChanges();
    }

    public bool Excluir(int id)
    {
        var discipline = ObterPorId(id);
        if(discipline == null)
        {
            return false;
        }
        else
        {
            _context.Disciplines.Remove(discipline);
            _context.SaveChanges();
            return true;
        }   
    }

    public List<Discipline> Listar()
    {
        return _context.Disciplines.ToList();
    }

    public Discipline ObterPorId(int id)
    {
        return _context.Disciplines.FirstOrDefault(x => x.Id == id);
    }
}