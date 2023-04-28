using ex5.Context;
using Microsoft.EntityFrameworkCore;
using ex5.Repositories;
using ex5.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Injeção de dependência dos Repositórios e Interfaces
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<IDisciplineRepository, DisciplineRepository>();
builder.Services.AddScoped<IStudentDisciplineRepository, StudentDisciplineRepository>();

// Injeção de dependência do Banco de Dados
builder.Services.AddDbContext<Contexto>(options => options.UseSqlite(builder.Configuration.GetConnectionString("Contexto")));


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
