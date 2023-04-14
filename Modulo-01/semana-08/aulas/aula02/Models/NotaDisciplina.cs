namespace aula02.Models;

public class NotaDisciplina
{

    public int Id { get; set; }

    public int DisciplinaId { get; set; }
    public decimal Nota { get; set; }
    public Disciplina Disciplina
     { get; set; }
}