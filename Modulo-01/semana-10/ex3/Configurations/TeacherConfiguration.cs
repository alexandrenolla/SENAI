using ex3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex3.Configuration;


public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
        .WithOne(x => x.Teacher)
        .HasForeignKey<Teacher>(x => x.UserId)
        .HasConstraintName("FK_User");

        builder.ToTable("Teacher");

    }
}