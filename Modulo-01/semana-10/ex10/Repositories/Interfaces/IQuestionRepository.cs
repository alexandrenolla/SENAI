using ex5.Models;

namespace ex5.Repositories.Interfaces;

public interface IQuestionRepository
{
    void Criar(Question question);

    void Atualizar(Question question);

    List<Question> Listar();

    Question ObterPorId(int id);

    bool Excluir(int id);
}