using Microsoft.EntityFrameworkCore;
using aula02.Configurations;

namespace aula02.Models;

public class LojaContexto : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Compra> Compras { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Promocao> Promocoes { get; set; }
    public DbSet<PromocaoProduto> PromocaoProdutos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ComprasConfiguration());

        modelBuilder.ApplyConfiguration(new PromocaoProdutoConfiguration());

        modelBuilder.ApplyConfiguration(new ClienteConfiguration());

    }
}

// public LojaContexto(DbContextOptions <LojaContexto> options) : base(options)
// {
    
// }