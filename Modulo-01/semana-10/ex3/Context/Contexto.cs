using Microsoft.EntityFrameworkCore;
using ex3.Models;
using ex3.Configuration;

namespace ex3.Context;

public class Contexto : DbContext
{
    public DbSet<Answer> Answers
     { get; set; }
     public DbSet<Discipline> Disciplines { get; set; }
     public DbSet<Question> Questions { get; set; }
     public DbSet<Quiz> Quizzes { get; set; }
     public DbSet<Student> Students { get; set; }
     public DbSet<StudentDiscipline> StudentDisciplines { get; set; }
     public DbSet<Teacher> Teachers { get; set; }
     public DbSet<User> Users { get; set; }

    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }

    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AnswerConfiguration());
        modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionConfiguration());
        modelBuilder.ApplyConfiguration(new QuizConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new StudentDisciplineConfiguration());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}