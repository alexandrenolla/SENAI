using ex5.Models;

namespace ex5.Repositories.Interfaces;

public interface ITeacherRepository
{
    // Assinaturas
    public List<Teacher> Listar();
    public Teacher? ObterPorId(int id);
    public void Criar(Teacher teacher);
    public void Atualizar(Teacher teacher);
    public bool Excluir(int id);
}
