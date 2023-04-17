using Microsoft.EntityFrameworkCore;
using aula02.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aula02.Configurations;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        // 1 para 1
        builder.HasOne(x => x.EnderecoDeEntrega)
        .WithOne(x => x.Cliente)
        .HasForeignKey<Cliente>(x => x.EnderecoId)
        .HasConstraintName("FK_Cliente_Endereco");
    }
}