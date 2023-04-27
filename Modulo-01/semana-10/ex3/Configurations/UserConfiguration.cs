using ex3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex3.Configuration;


public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Teacher)
        .WithOne(x => x.User);

        builder.HasOne(x => x.Student)
        .WithOne(x => x.User);
    }
}