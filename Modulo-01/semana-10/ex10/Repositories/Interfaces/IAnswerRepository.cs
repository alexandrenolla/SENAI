using ex5.Models;

namespace ex5.Repositories.Interfaces;

public interface IAnswerRepository
{
    void Criar(Answer answer);

    void Atualizar(Answer answer);

    List<Answer> Listar();

    Answer ObterPorId(int id);

    bool Excluir(int id);
}