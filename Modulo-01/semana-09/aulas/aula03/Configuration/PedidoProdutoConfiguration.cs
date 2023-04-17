using Microsoft.EntityFrameworkCore;
using aula03.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aula03.Configuration;

public class PedidoProdutoConfiguration : IEntityTypeConfiguration<PedidoProduto>
{
    public void Configure(EntityTypeBuilder<PedidoProduto> builder)
    {
        builder.HasKey(x => x.Id);

        // 1 para muitos
        builder.HasOne(x =>x.Produto)
        .WithMany(x =>x.Pedidos)
        .HasForeignKey(x =>x.Pedido_Id)
        .OnDelete(DeleteBehavior.ClientSetNull)
        .HasConstraintName("FK_Produto_Pedido");

        // 1 para muitos
        builder.HasOne(x =>x.Pedido)
        .WithMany(x =>x.Produtos)
        .HasForeignKey(x =>x.Produto_Id)
        .OnDelete(DeleteBehavior.ClientSetNull)
        .HasConstraintName("FK_Pedido_Produto");

    }
}