using Microsoft.EntityFrameworkCore;
using ex2.Models;

namespace ex2.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }
}