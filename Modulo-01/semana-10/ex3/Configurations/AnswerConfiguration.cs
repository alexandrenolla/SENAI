using ex3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex3.Configuration;


public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
{
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Student)
        .WithMany(x => x.Answers)
        .HasForeignKey(x => x.StudentId)
        .HasConstraintName("FK_Student");

        builder.HasOne(x => x.Question)
        .WithOne(x => x.Answer)
        .HasForeignKey<Answer>(x => x.QuestionId)
        .HasConstraintName("FK_Question");

        builder.ToTable("Answer");
    }
}