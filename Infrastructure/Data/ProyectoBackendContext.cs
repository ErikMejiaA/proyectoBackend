using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ProyectoBackendContext : DbContext
{
    public ProyectoBackendContext(DbContextOptions<ProyectoBackendContext> options) : base(options)
    {

    }

    //creamos la referencia a la entidad 
    public DbSet<User> ? Users { get; set; }
    public DbSet<Bodega> ? Bodegas { get; set; }
    public DbSet<Producto> ? Productos { get; set; }
    public DbSet<Inventario> ? Inventarios { get; set; }
    public DbSet<Historial> ? Historiales { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
