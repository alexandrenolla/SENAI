using aula01.Context;
using aula01.Models;
using Microsoft.AspNetCore.Mvc;

namespace aula01.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase {
    
    private readonly MovieContext _context;

    public MovieController(MovieContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {   
       var movies = _context.Movies.ToList(); 
        return Ok(movies);
    }

    [HttpPost]
    [Route("Criar")]
    public IActionResult Create([FromBody] Movie movie)
    {   
        _context.Movies.Add(movie);
        _context.SaveChanges();

        return CreatedAtAction(nameof(MovieController.Get), new {id = movie.Id}, movie);
    }

}