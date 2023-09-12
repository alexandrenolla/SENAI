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
             //Relacionamentos entre as tabelas
            modelBuilder.Entity<FichaModel>()
                        .HasMany(x => x.Detalhes)
                        .WithOne(y => y.Ficha)
                        .Metadata
                        .DeleteBehavior =  DeleteBehavior.Restrict;

            modelBuilder.Entity<FichaModel>()
                        .HasMany(x => x.Telefones)
                        .WithOne(y => y.Ficha)
                        .Metadata
                        .DeleteBehavior =  DeleteBehavior.Restrict;
            
            modelBuilder.Entity<DetalheModel>()
                        .Property(p => p.DataCadastro)
                        .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<FichaModel>()
                        .Property(p => p.DataCadastro)
                        .HasDefaultValue(DateTime.Now);

            // carga de dados iniciais da tabela
            modelBuilder.Entity<FichaModel>().HasData(
            new FichaModel{
                Id = 1,
                DataNascimento = new DateTime(1997, 10, 14),
                Email = "testes@email.com.br",
                Nome = "Teste"
            },
            new FichaModel{
                Id = 2,
                DataNascimento = new DateTime(1997, 10, 14),
                Email = "testes2@email.com.br",
                Nome = "Teste2"
            },
            new FichaModel{
                Id = 3,
                DataNascimento = new DateTime(1997, 10, 14),
                Email = "testes3@email.com.br",
                Nome = "Teste3"
            },
            new FichaModel{
                Id = 9,
                DataNascimento = new DateTime(1997, 10, 14),
                Email = "testes9@email.com.br",
                Nome = "Teste9"
            },
            new FichaModel{
                Id = 4,
                DataNascimento = new DateTime(1997, 10, 14),
                Email = "testes4@email.com.br",
                Nome = "Teste4"
            },
            new FichaModel{
                Id = 5,
                DataNascimento = new DateTime(1997, 10, 14),
                Email = "testes5@email.com.br",
                Nome = "Teste5"
            },
            new FichaModel{
                Id = 6,
                DataNascimento = new DateTime(1997, 10, 14),
                Email = "testes6@email.com.br",
                Nome = "Teste6"
            },
            new FichaModel{
                Id = 7,
                DataNascimento = new DateTime(1997, 10, 14),
                Email = "testes7@email.com.br",
                Nome = "Teste7"
            },
            new FichaModel{
                Id = 8,
                DataNascimento = new DateTime(1997, 10, 14),
                Email = "testes8@email.com.br",
                Nome = "Teste8"
            },
            new FichaModel{
                Id = 10,
                DataNascimento = new DateTime(1997, 10, 14),
                Email = "testes10@email.com.br",
                Nome = "Teste10"
            }
            );
        }
    }
}