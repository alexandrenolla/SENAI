namespace aula02.Models;

public class Aluno : Pessoa
{
    public int Id { get; set; }
    public List<NotaDisciplina> Notas { get; set; }

}