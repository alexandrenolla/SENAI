using ex5.Models;

namespace ex5.Repositories.Interfaces;

public interface IQuizRepository
{
    void Criar(Quiz quiz);

    void Atualizar(Quiz quiz);

    List<Quiz> Listar();

    Quiz ObterPorId(int id);

    bool Excluir(int id);
}