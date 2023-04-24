namespace ex3.Models;


public class Student {
   public int UserId {get; set;}
   public int Period {get; set;}
   public int RA {get; set;}

   public virtual ICollection<StudentDiscipline> Disciplines { get; set; }

   public virtual User User { get; set; }

   public virtual ICollection<Answer> Answers { get; set; }

}