using ex5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex5.Configuration;


public class StudentDisciplineConfiguration : IEntityTypeConfiguration<StudentDiscipline>
{
    public void Configure(EntityTypeBuilder<StudentDiscipline> builder)
    {   
        builder.HasKey(x => x.Id);
        
        builder.HasOne(x => x.Student)
        .WithMany(x => x.Disciplines)
        .HasForeignKey(x => x.StudentId)
        .HasConstraintName("FK_Student");

        builder.HasOne(x => x.Discipline)
        .WithMany(x => x.Students)
        .HasForeignKey(x => x.DisciplineId)
        .HasConstraintName("FK_Discipline");

        builder.ToTable("Student_Discipline");
    }
}