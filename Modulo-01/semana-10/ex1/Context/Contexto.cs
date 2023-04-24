using Microsoft.EntityFrameworkCore;

namespace ex1.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }
}