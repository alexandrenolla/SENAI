using ex3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex3.Configuration;


public class StudentDisciplineConfiguration : IEntityTypeConfiguration<StudentDiscipline>
{
    public void Configure(EntityTypeBuilder<StudentDiscipline> builder)
    {
        throw new NotImplementedException();
    }
}