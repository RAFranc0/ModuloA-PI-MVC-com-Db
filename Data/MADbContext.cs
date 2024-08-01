using Atv4.Models;
using Microsoft.EntityFrameworkCore;

namespace Atv4.Data
{
    public class MADbContext : DbContext
{
    public MADbContext(DbContextOptions<MADbContext> options) : base(options)
    {
    }

    public DbSet<UsuarioViewModel> Usuarios { get; set; }
    public DbSet<EventoViewModel> Eventos { get; set; }
    public DbSet<ContatoViewModel> Contatos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=destinocerto_db;User=root;Password=yourpassword");
        }
    }
}
}