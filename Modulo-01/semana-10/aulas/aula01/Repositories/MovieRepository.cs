using aula01.Context;
using aula01.Models;
using aula01.Repositories.Interfaces;

namespace aula01.Repositories;

public class MovieRepository : IMovieRepository
{
    // Injeção de dependência do Context
    private readonly MovieContext _context;

    public MovieRepository(MovieContext context)
    {
        _context = context;
    }

    public void Adicionar(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
    }

    public void Atualizar(Movie movie)
    {
        _context.Movies.Update(movie);
        _context.SaveChanges();
    }

    public void Excluir(int id)
    {
        var movie = ObterPorId(id);
        _context.Movies.Remove(movie);
        _context.SaveChanges();
    }

    public List<Movie> ObterLista()
    {
        return _context.Movies.ToList(); 
    }

    public Movie ObterPorId(int id)
    {
        return _context.Movies.FirstOrDefault(x => x.Equals(id)); // retorna nulo se não achar
    }
}