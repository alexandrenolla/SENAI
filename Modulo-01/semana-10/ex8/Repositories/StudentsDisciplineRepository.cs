using ex5.Repositories.Interfaces;
using ex5.Context;
using ex5.Models;

namespace ex5.Repositories;


public class StudentDisciplineRepository : IStudentDisciplineRepository
{
    private readonly Contexto _context;

    public StudentDisciplineRepository(Contexto context)
    {
        _context = context;
    }
    public List<StudentDiscipline> Listar()
    {

        return _context.StudentDisciplines.ToList();
    }

    public StudentDiscipline? ObterPorId(int id)
    {
        return _context.StudentDisciplines.FirstOrDefault(x => x.Id.Equals(id));
    }

    public void Criar(StudentDiscipline studentDiscipline)
    {
        _context.StudentDisciplines.Add(studentDiscipline);
        _context.SaveChanges();
    }

    public void Atualizar(StudentDiscipline studentDiscipline)
    {
        _context.Update(studentDiscipline);
        _context.SaveChanges();
    }

    public bool Excluir(int id)
    {
        var studentDiscipline = ObterPorId(id);
        if (studentDiscipline == null)
        {
            return false;
        }
        else
        {
            _context.StudentDisciplines.Remove(studentDiscipline);
            _context.SaveChanges();
            return true;
        }
        
    }
}

