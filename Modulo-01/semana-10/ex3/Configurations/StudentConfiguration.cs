using ex3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex3.Configuration;


public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(a => a.User)
        .WithOne(s => s.Student)
        .HasForeignKey<Student>(y => y.UserId)
        .HasConstraintName("FK_User");

        builder.HasMany(x => x.Disciplines)
        .WithOne(x => x.Student);

        builder.HasMany(x => x.Answers)
        .WithOne(x => x.Student);
    }
}