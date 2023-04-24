namespace ex2.Models;

public class Teacher
{
    public int UserId { get; set; }
    public string Department { get; set; }

    public virtual User User { get; set; }
    public virtual ICollection<Discipline> Disciplines { get; set; }
}