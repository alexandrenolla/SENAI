namespace aula02.Models;

public class Professor : Pessoa
{ 
    public int Id { get; set; }
    public Disciplina Disciplina { get; set; }
}