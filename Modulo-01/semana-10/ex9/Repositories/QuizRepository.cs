using ex5.Repositories.Interfaces;
using ex5.Context;
using ex5.Models;

namespace ex5.Repositories;


public class QuizRepository : IQuizRepository
{
    private readonly Contexto _context;

    public QuizRepository(Contexto context)
    {
        _context = context;
    }
    public List<Quiz> Listar()
    {

        return _context.Quizzes.ToList();
    }

    public Quiz? ObterPorId(int id)
    {
        return _context.Quizzes.FirstOrDefault(x => x.Id.Equals(id));
    }

    public void Criar(Quiz quiz)
    {
        _context.Quizzes.Add(quiz);
        _context.SaveChanges();
    }

    public void Atualizar(Quiz quiz)
    {
        _context.Update(quiz);
        _context.SaveChanges();
    }

    public bool Excluir(int id)
    {
        var quiz = ObterPorId(id);
        if (quiz == null)
        {
            return false;
        }
        else
        {
            _context.Quizzes.Remove(quiz);
            _context.SaveChanges();
            return true;
        }
        
    }
}

