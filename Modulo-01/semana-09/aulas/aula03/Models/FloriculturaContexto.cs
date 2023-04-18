using aula03.Configuration;
using Microsoft.EntityFrameworkCore;

namespace aula03.Models;
    // Classe que representa o BD
public class FloriculturaContexto : DbContext
{   // Propriedades que representam as Tabelas
    public DbSet <Cliente> Clientes { get; set; }
    public DbSet <Estoque> Estoques { get; set; }
    public DbSet <TipoProduto> TipoProdutos { get; set; }
    public DbSet <Produto> Produtos { get; set; }
    public DbSet <Pedido> Pedidos { get; set; }
    public DbSet <PedidoProduto> PedidoProdutos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PedidoConfiguration());
        modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        modelBuilder.ApplyConfiguration(new PedidoProdutoConfiguration());
        modelBuilder.ApplyConfiguration(new EstoqueConfiguration());
        modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        modelBuilder.ApplyConfiguration(new TipoConfiguration());
    }

    public FloriculturaContexto(DbContextOptions<FloriculturaContexto> options) : base(options)
        {
            
        }
}