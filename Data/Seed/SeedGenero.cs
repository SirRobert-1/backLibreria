using backendnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backendnet.Data.Seed;

public class SeedGenero : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.HasData(
            new Genero { GeneroId = 1, Nombre = "Ciberpunk", Protegida = true },
            new Genero { GeneroId = 2, Nombre = "Steampunk", Protegida = true },
            new Genero { GeneroId = 3, Nombre = "Poesía", Protegida = true },
            new Genero { GeneroId = 4, Nombre = "Ciencia ficción", Protegida = true },
            new Genero { GeneroId = 5, Nombre = "Thriller", Protegida = true },
            new Genero { GeneroId = 6, Nombre = "Distopia", Protegida = true },
            new Genero { GeneroId = 7, Nombre = "Biografía", Protegida = true },
            new Genero { GeneroId = 8, Nombre = "Autobiografía", Protegida = true },
            new Genero { GeneroId = 9, Nombre = "Belica", Protegida = true },
            new Genero { GeneroId = 10, Nombre = "Fantasia", Protegida = true },
            new Genero { GeneroId = 11, Nombre = "Aventura", Protegida = true },
            new Genero { GeneroId = 12, Nombre = "Terror", Protegida = true },
            new Genero { GeneroId = 13, Nombre = "Epica", Protegida = true },
            new Genero { GeneroId = 14, Nombre = "Misterio", Protegida = true },
            new Genero { GeneroId = 15, Nombre = "Romance", Protegida = true }
        );
    }
}