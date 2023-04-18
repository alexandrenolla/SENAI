using Microsoft.EntityFrameworkCore;
using ex1.Models;

namespace ex1.Context;

public class BercarioContexto : DbContext
{

    public DbSet <MedicoModel> Medicos { get; set; }
    public DbSet <PartoModel> Partos { get; set; }
    public DbSet <BebeModel> Bebes { get; set; }
    public DbSet <MaeModel> Maes { get; set; }
    







    public BercarioContexto(DbContextOptions<BercarioContexto> options) : base(options)
        {
            
        } 
}