using ex4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex4.Configuration;


public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Quiz)
        .WithMany(x => x.Questions)
        .HasForeignKey(x => x.QuizId)
        .HasConstraintName("FK_Quiz");

        builder.ToTable("Question");
    }
}