using Microsoft.EntityFrameworkCore;
using aula03.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aula03.Configuration;

public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Cliente)
        .WithMany(x => x.Pedidos)
        .HasForeignKey(x => x.Cliente_Id)
        .HasConstraintName("FK_Pedido_Cliente");

        builder.ToTable("Pedido");
    }
}