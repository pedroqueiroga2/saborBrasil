using SaborDoBrasil.Data;
using Microsoft.EntityFrameworkCore;
using SaborDoBrasil.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuração do MySQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

var app = builder.Build();

app.UseDefaultFiles(); // Serve index.html por padrão
app.UseStaticFiles(); // Permite servir arquivos da pasta wwwroot
// Endpoint para Publicações
app.MapGet("/api/publicacoes", async (AppDbContext db) =>
{
    var publicacoes = await db.Publicacoes
                             .Include(p => p.Usuario)
                             .ToListAsync();
    return Results.Ok(publicacoes);
});

app.MapGet("/", context =>
{
    context.Response.Redirect("/index.html");
    return Task.CompletedTask;
});

app.Run();