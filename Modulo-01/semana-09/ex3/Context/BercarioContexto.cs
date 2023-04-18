using Microsoft.EntityFrameworkCore;
using ex2.Models;
using ex2.Configuration;

namespace ex2.Context;

public class BercarioContexto : DbContext
{

    public DbSet <MedicoModel> Medicos { get; set; }
    public DbSet <PartoModel> Partos { get; set; }
    public DbSet <BebeModel> Bebes { get; set; }
    public DbSet <MaeModel> Maes { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BebeConfiguration());
        modelBuilder.ApplyConfiguration(new MaeConfiguration());
        modelBuilder.ApplyConfiguration(new MedicoConfiguration());
        modelBuilder.ApplyConfiguration(new PartoConfiguration());
    }

    public BercarioContexto(DbContextOptions<BercarioContexto> options) : base(options)
        {
            
        } 
}