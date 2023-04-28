using ex5.Models;

namespace ex5.Repositories.Interfaces;

public interface IDisciplineRepository
{
    void Criar(Discipline discipline);

    void Atualizar(Discipline discipline);

    List<Discipline> Listar();

    Discipline ObterPorId(int id);

    bool Excluir(int id);
}