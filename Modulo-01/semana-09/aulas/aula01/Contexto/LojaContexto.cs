using aula01.Models;
using Microsoft.EntityFrameworkCore;

namespace aula01.Contexto;

public class LojaContexto : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    
}