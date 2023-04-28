using ex4.Models;

namespace ex4.Repositories.Interfaces;

public interface IStudentRepository
{
    void Criar(Student student);

    void Atualizar(Student student);

    List<Student> Listar();

    Student ObterPorId(int id);

    bool Excluir(int id);
}