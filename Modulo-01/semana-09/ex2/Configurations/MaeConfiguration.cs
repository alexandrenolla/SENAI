namespace ex2.Configuration;

using ex2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MaeConfiguration : IEntityTypeConfiguration<MaeModel>
{
    public void Configure(EntityTypeBuilder<MaeModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
        .HasMaxLength(60);
        builder.Property(x => x.Endereco)
        .HasMaxLength(300);
        builder.Property(x => x.Telefone)
        .HasMaxLength(20);
        
        builder.ToTable("Mae");
    }
}