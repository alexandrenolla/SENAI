using aula01.Context;
using aula01.Models;
using aula01.Repositories;
using aula01.Repositories.Interfaces;
using aula01.Validators;
using Microsoft.AspNetCore.Mvc;
using aula01.Dtos;

namespace aula01.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase {
    
    private readonly IMovieRepository _movieRepository;

    public MovieController(IMovieRepository movierepository)
    {
        _movieRepository = movierepository;    
    }

    [HttpGet]
    public IActionResult Get()
    {   
       var movie = _movieRepository.ObterLista();
        return Ok(movie);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {   
       var movie = _movieRepository.ObterPorId(id);
       if (movie == null)
       {
        return NotFound();
       }
        return Ok(movie);
    }

    [HttpPost]
    [Route("Criar")]
    public async Task<IActionResult> Create([FromBody] FilmeCriacaoDto movieDto)
    {   

        // Verificação se as regras do Validator foram cumpridas no novo objeto.
        if(ModelState.IsValid == false)
        {
            return StatusCode(StatusCodes.Status400BadRequest, ModelState);
        }
        //

        var movie = new Movie();
        movie.Titulo = movieDto.Titulo;
        movie.Genero = movieDto.Genero;
        movie.DataDeLancamento = movieDto.DataDeLancamento;

        _movieRepository.Adicionar(movie);

        return CreatedAtAction(nameof(MovieController.Get), new {id = movie.Id}, movieDto);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] FilmeAlteracaoDto movieDto)
    {   

        var movie = _movieRepository.ObterPorId(id);
        if (movie == null)
        {
            return NotFound();
        }
        movie.Titulo = movieDto.Titulo;
        movie.Genero = movieDto.Genero;
        
        return CreatedAtAction(nameof(MovieController.Get), new {id = movie.Id}, movieDto);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> Delete(int id, [FromBody] FilmeAlteracaoDto movieDto)
    {   
        var movie = _movieRepository.ObterPorId(id);
        if (movie == null)
        {
            return NotFound();
        }
        
        _movieRepository.Excluir(id);

        return NoContent();
    }

}