namespace ex2.Models;

public class StudentsDiscipline
{
    public int StudentId { get; set; }
    public int DisciplineId { get; set; }

    public virtual Student Student { get; set; }
    public virtual Discipline Discipline { get; set; }
}