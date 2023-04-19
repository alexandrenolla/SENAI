using aula01.Models;
using Microsoft.EntityFrameworkCore;

namespace aula01.Context;

public class MovieContext : DbContext
{

    public DbSet<Movie> Movies { get; set; }



    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
        
    }
}