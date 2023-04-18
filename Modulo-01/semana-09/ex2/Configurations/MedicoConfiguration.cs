namespace ex2.Configuration;

using ex2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MedicoConfiguration : IEntityTypeConfiguration<MedicoModel>
{
    public void Configure(EntityTypeBuilder<MedicoModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.CRM)
        .HasMaxLength(15);
        builder.Property(x => x.Nome)
        .HasMaxLength(60);
        builder.Property(x => x.Especialidade)
        .HasMaxLength(100);

        builder.ToTable("Medico");
    }
}