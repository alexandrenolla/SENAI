using aula03.Models;
using Microsoft.EntityFrameworkCore;

namespace aula03.Configuration;

public class EstoqueConfiguration : IEntityTypeConfiguration<Estoque>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Estoque> builder)
    {
        builder.HasKey(x => x.Id);

        builder.ToTable("Estoque");
    }
}