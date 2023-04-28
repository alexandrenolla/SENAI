using ex5.Repositories.Interfaces;
using ex5.Context;
using ex5.Models;

namespace ex5.Repositories;


public class AnswerRepository : IAnswerRepository
{
    private readonly Contexto _context;

    public AnswerRepository(Contexto context)
    {
        _context = context;
    }
    public List<Answer> Listar()
    {

        return _context.Answers.ToList();
    }

    public Answer? ObterPorId(int id)
    {
        return _context.Answers.FirstOrDefault(x => x.Id.Equals(id));
    }

    public void Criar(Answer answer)
    {
        _context.Answers.Add(answer);
        _context.SaveChanges();
    }

    public void Atualizar(Answer answer)
    {
        _context.Update(answer);
        _context.SaveChanges();
    }

    public bool Excluir(int id)
    {
        var answer = ObterPorId(id);
        if (answer == null)
        {
            return false;
        }
        else
        {
            _context.Answers.Remove(answer);
            _context.SaveChanges();
            return true;
        }
        
    }
}

