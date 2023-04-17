using aula03.Models;
using Microsoft.EntityFrameworkCore;

namespace aula03.Configuration;

public class TipoConfiguration : IEntityTypeConfiguration<TipoProduto>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TipoProduto> builder)
    {
        builder.HasKey(x => x.Id);

        builder.ToTable("Tipo_Produto");
    }
}