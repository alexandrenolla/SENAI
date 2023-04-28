using ex5.Models;

namespace ex5.Repositories.Interfaces;

public interface IStudentDisciplineRepository
{
    void Criar(StudentDiscipline discipline);

    void Atualizar(StudentDiscipline discipline);

    List<StudentDiscipline> Listar();

    StudentDiscipline ObterPorId(int id);

    bool Excluir(int id);
}