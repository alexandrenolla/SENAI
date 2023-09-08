using FichaCadastroAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FichaCadastroAPI.Context 
{
    public class FichaCadastroDbContext : DbContext
    {
        public DbSet<DetalheModel> Detalhes { get; set; }
        public DbSet<FichaModel> Fichas { get; set; }
        public DbSet<TelefoneModel> Telefones { get; set; }

        public FichaCadastroDbContext(DbContextOptions options) : base(options)
        {
        }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}