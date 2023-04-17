using Microsoft.EntityFrameworkCore;
using aula02.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aula02.Configurations;

public class PromocaoProdutoConfiguration : IEntityTypeConfiguration<PromocaoProduto>
{
    public void Configure(EntityTypeBuilder<PromocaoProduto> builder)
    {
        builder.HasOne(x => x.Promocao)
        .WithMany(x => x.Produtos)
        .HasForeignKey(x => x.PromocaoId)
        .HasConstraintName("FK_Promocao_Produto");

        builder.HasOne(x => x.Produto)
        .WithMany(x => x.Promocoes)
        .HasForeignKey(x => x.ProdutoId)
        .HasConstraintName("FK_Produto_Promocao");
    }
}