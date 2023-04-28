using ex5.Models;

namespace ex5.Repositories.Interfaces;

public interface IStudentRepository
{
    void Criar(Student student);

    void Atualizar(Student student);

    List<Student> Listar();

    Student ObterPorId(int id);

    bool Excluir(int id);
}