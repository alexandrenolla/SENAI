using ex3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex3.Configuration;


public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
{
    public void Configure(EntityTypeBuilder<Discipline> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Teacher)
        .WithMany(x => x.Disciplines)
        .HasForeignKey(x => x.TeacherId)
        .HasConstraintName("FK_Teacher");

        builder.HasMany(x => x.Students)
        .WithOne(x => x.Discipline);

        builder.HasMany(x => x.Quizzes)
        .WithOne(x => x.Discipline);

    }
}