namespace ex3.Models;

public class StudentDiscipline
{
    public int StudentId { get; set; }
    public int DisciplineId { get; set; }

    public virtual Student Student { get; set; }
    public virtual Discipline Discipline { get; set; }
}