namespace ex2.Configuration;

using ex2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BebeConfiguration : IEntityTypeConfiguration<BebeModel>
{
    public void Configure(EntityTypeBuilder<BebeModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Peso_Nascimento)
        .HasColumnType("decimal 4,3");

        builder.HasOne(x => x.Mae)
        .WithMany(x => x.Bebes)
        .HasForeignKey(x => x.Id_Mae)
        .HasConstraintName("FK_Mae");

        builder.HasOne(x => x.Parto)
        .WithMany(x => x.Bebes)
        .HasForeignKey(x => x.Id_Parto)
        .HasConstraintName("FK_Parto");

        builder.ToTable("Bebe");
    }
}