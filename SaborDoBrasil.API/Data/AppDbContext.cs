using Microsoft.EntityFrameworkCore;
using SaborDoBrasil.API.Models;

namespace SaborDoBrasil.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Publicacao> Publicacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
