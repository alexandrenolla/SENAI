using FichaCadastroAPI.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Connection String
string connectionString = "Data Source=/Users/alexandrenolla/Documents/dev/SENAI/Modulo-03/semana-02/fichaCadastro.db;";

//string connectionString = "Server=sql_server,1433;Database=FichaCadastro;Trusted_Connection=False;TrustServerCertificate=False;User ID=sa;password=P@ssw0rd123!";

// Configure Dependency Injection from Context to Connection String
builder.Services.AddDbContext<FichaCadastroDbContext>(options => options.UseSqlite(connectionString));

// Configure AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

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
