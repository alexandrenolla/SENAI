using ex3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex3.Configuration;


public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Discipline)
        .WithMany(x => x.Quizzes)
        .HasForeignKey(x => x.DisciplineId)
        .HasConstraintName("FK_Discipline");

        builder.ToTable("Quiz");
    }
}