using ex5.Repositories.Interfaces;
using ex5.Context;
using ex5.Models;

namespace ex5.Repositories;


public class QuestionRepository : IQuestionRepository
{
    private readonly Contexto _context;

    public QuestionRepository(Contexto context)
    {
        _context = context;
    }
    public List<Question> Listar()
    {

        return _context.Questions.ToList();
    }

    public Question? ObterPorId(int id)
    {
        return _context.Questions.FirstOrDefault(x => x.Id.Equals(id));
    }

    public void Criar(Question question)
    {
        _context.Questions.Add(question);
        _context.SaveChanges();
    }

    public void Atualizar(Question question)
    {
        _context.Update(question);
        _context.SaveChanges();
    }

    public bool Excluir(int id)
    {
        var question = ObterPorId(id);
        if (question == null)
        {
            return false;
        }
        else
        {
            _context.Questions.Remove(question);
            _context.SaveChanges();
            return true;
        }
        
    }
}

