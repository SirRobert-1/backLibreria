using backendnet.Data.Seed;
using backendnet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backendnet.Data;
public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<CustomIdentityUser>(options)
{
    public DbSet<Libro> Libro { get; set; }

    public DbSet<Genero> Genero { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SeedGenero());
        modelBuilder.ApplyConfiguration(new SeedLibro());
        modelBuilder.SeedUserIdentityData();

        base.OnModelCreating(modelBuilder);
    }
}