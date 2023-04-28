using ex5.Context;
using ex5.Models;
using ex5.Repositories.Interfaces;

namespace ex5.Repositories;

public class StudentRepository : IStudentRepository
{   
    // Injeção de dependência do Context
    private readonly Contexto _context;

    // Assinatura
    public StudentRepository (Contexto context)
    {
        _context = context;
    }

    public void Atualizar(Student student)
    {
        _context.Students.Update(student);
        _context.SaveChanges();
    }

    public void Criar(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();
    }

    public bool Excluir(int id)
    {
        var student = ObterPorId(id);
        if(student == null)
        {
            return false;
        }
        else
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
            return true;
        }   
    }

    public List<Student> Listar()
    {
        return _context.Students.ToList();
    }

    public Student ObterPorId(int id)
    {
        return _context.Students.FirstOrDefault(x => x.Id == id);
    }
}