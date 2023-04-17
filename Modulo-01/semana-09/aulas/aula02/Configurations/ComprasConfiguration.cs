using aula02.Models;
using Microsoft.EntityFrameworkCore;

namespace aula02.Configurations;

public class ComprasConfiguration : IEntityTypeConfiguration<Compra>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Compra> builder)
    {
        builder.HasOne(x => x.ProdutoCompra)
        .WithMany(x => x.Compras)
        .HasForeignKey(x => x.ProdutoId)
        .HasConstraintName("FK_Compra_Produto");

        builder.HasOne(x => x.ClienteCompra)
        .WithMany(x => x.Compras)
        .HasForeignKey(x => x.ClienteId)
        .HasConstraintName("FK_Compra_Cliente");
    }
}