using Microsoft.EntityFrameworkCore;
using aula03.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aula03.Configuration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
        .HasMaxLength(150);

        builder.ToTable("Cliente");
    }
}