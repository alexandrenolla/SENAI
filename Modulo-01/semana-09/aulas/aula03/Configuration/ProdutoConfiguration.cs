using aula03.Models;
using Microsoft.EntityFrameworkCore;

namespace aula03.Configuration;

public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Produto> builder)
    {
        builder.HasKey(x => x.Id);

        // 1 para muitos
        builder.HasOne(x => x.Tipo) // 1
        .WithMany(x => x.Produtos) // muitos
        .HasForeignKey(x => x.Tipo_Id) // FK
        .OnDelete(DeleteBehavior.ClientSetNull)
        .HasConstraintName("FK_Produto_Tipo"); // Nome da FK

        // 1 para 1 
        builder.HasOne(x => x.Estoque) // 1
        .WithOne(x => x.Produto) // 1
        .HasForeignKey<Produto>(x => x.Estoque_Id) // REGRA: de 1 para 1 sempre precisa referenciar a classe que está a FK
        .OnDelete(DeleteBehavior.ClientSetNull)
        .HasConstraintName("FK_Produto_Estoque"); // Nome

        builder.ToTable("Produto");
    }
}
