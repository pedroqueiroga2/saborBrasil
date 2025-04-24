using Microsoft.EntityFrameworkCore;
using SaborDoBrasil.Models;

namespace SaborDoBrasil.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Publicacao> Publicacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publicacao>()
                .HasOne(p => p.Usuario)
                .WithMany(u => u.Publicacoes)
                .HasForeignKey(p => p.UsuarioId);
        }
    }
}