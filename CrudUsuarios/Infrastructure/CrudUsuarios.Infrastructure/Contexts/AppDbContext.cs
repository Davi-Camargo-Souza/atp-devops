using CrudUsuarios.Domain.Contexts.Usuarios.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudUsuarios.Infrastructure.Contexts.Usuarios;

public class AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=usuarios.db");
}