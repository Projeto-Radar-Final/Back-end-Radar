using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Projeto_Radar.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var conexao = Environment.GetEnvironmentVariable("DATABASE_URL");
Console.WriteLine($"==============================={conexao}===========================");
builder.Services.AddDbContext<DBContext>(options => options.UseMySql(conexao, ServerVersion.AutoDetect(conexao)));
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
