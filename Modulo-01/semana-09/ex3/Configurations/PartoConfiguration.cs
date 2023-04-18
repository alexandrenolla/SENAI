namespace ex2.Configuration;

using ex2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


public class PartoConfiguration : IEntityTypeConfiguration<PartoModel>
{
    public void Configure(EntityTypeBuilder<PartoModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Medico)
        .WithMany(x => x.Partos)
        .HasForeignKey(x => x.Id_Medico)
        .HasConstraintName("FK_Medico");

        builder.ToTable("Parto");
    }
}