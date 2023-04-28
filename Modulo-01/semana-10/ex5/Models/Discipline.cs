namespace ex5.Models;

public class Discipline
{
    public int Id { get; set; }
    public int TeacherId { get; set; }
    public string DisciplineName { get; set; }

    public virtual ICollection<StudentDiscipline> Students { get; set; }
    public virtual Teacher Teacher { get; set; }
    public virtual ICollection<Quiz> Quizzes { get; set; }
}