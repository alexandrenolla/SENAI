using aula01.Context;
using aula01.Repositories;
using aula01.Repositories.Interfaces;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(options =>
  {
     // Validate child properties and root collection elements
     options.ImplicitlyValidateChildProperties = true;
     options.ImplicitlyValidateRootCollectionElements = true;

     // Automatic registration of validator in assembly
     options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
  });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Registro da injeção de dependência da interface na controller
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
//

// Injeção de dependência do contexto
builder.Services.AddDbContext<MovieContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("MovieContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
