using ex5.Repositories.Interfaces;
using ex5.Context;
using ex5.Models;

namespace ex5.Repositories;


public class TeacherRepository : ITeacherRepository
{
    private readonly Contexto _context;

    public TeacherRepository(Contexto context)
    {
        _context = context;
    }
    public List<Teacher> Listar()
    {

        return _context.Teachers.ToList();
    }

    public Teacher? ObterPorId(int id)
    {
        return _context.Teachers.FirstOrDefault(x => x.Id.Equals(id));
    }

    public void Criar(Teacher teacher)
    {
        _context.Teachers.Add(teacher);
        _context.SaveChanges();
    }

    public void Atualizar(Teacher teacher)
    {
        _context.Update(teacher);
        _context.SaveChanges();
    }

    public bool Excluir(int id)
    {
        var teacher = ObterPorId(id);
        if (teacher == null)
        {
            return false;
        }
        else
        {
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
            return true;
        }
        
    }
}

