using System.Data.Common;
using backend.Models;
using backendnet.Data;
using backendnet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendnet.Controllers;

[Route("api/[controller]")]
[ApiController]

public class LibrosController(IdentityContext context) : Controller
{
    [HttpGet]
    [Authorize(Roles = "Usuario, Administrador")]

    public async Task<ActionResult<IEnumerable<Libro>>> GetLibros(string? s)
    {
        if (string.IsNullOrEmpty(s))
            return await context.Libro.Include(i => i.Generos).AsNoTracking().ToListAsync();
        return await context.Libro.Include(i => i.Generos).AsNoTracking().ToListAsync();
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "Usuario, Administrador")]

    public async Task<ActionResult<Libro>> GetLibro(int id)
    {
        var libro = await context.Libro.Include(i => i.Generos).AsNoTracking().FirstOrDefaultAsync(s => s.LibroId == id);

        if (libro == null)
        {
            return NotFound();
        }

        return libro;
    }

    [HttpPost]
    [Authorize(Roles = "Administrador")]

    public async Task<ActionResult<Libro>> PostLibro(LibroDTO libroDTO)
    {
        Libro libro = new()
        {
            Titulo = libroDTO.Titulo,
            Sinopsis = libroDTO.Sinopsis,
            Anio = libroDTO.Anio,
            Portada = libroDTO.Portada,
            Generos = []

        };

        if (libroDTO.Genero != null)
        {
            foreach (var categoriaId in libroDTO.Genero)
            {
                Genero? genero = await context.Genero.FindAsync(categoriaId);
                if (genero != null)
                    libro.Generos.Add(genero);
            }
        }

        context.Libro.Add(libro);
        await context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetLibro), new { id = libro.LibroId }, libro);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Administrador")]

    public async Task<IActionResult> PutLibro(int id, LibroDTO libroDTO)
    {
        if (id != libroDTO.LibroId)
        {
            return BadRequest();
        }

        var libro = await context.Libro.Include(i => i.Generos).FirstOrDefaultAsync(s => s.LibroId == id);

        if (libro == null)
        {
            return NotFound();
        }

        libro.Titulo = libroDTO.Titulo;
        libro.Sinopsis = libroDTO.Sinopsis;
        libro.Anio = libroDTO.Anio;
        libro.Portada = libroDTO.Portada;
        libro.Generos = [];

        if (libro.Generos != null)
        {
            foreach (var generoId in libroDTO.Genero)
            {
                Genero? genero = await context.Genero.FindAsync(generoId);
                if (genero != null)
                    libro.Generos.Add(genero);
            }
        }

        try
        {
            await context.SaveChangesAsync();
        }
        catch (DbException ex)
        {
            Console.WriteLine(ex.Message);
            return BadRequest();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Administrador")]

    public async Task<IActionResult> DeleteLibro(int id)
    {
        var libro = await context.Libro.FindAsync(id);
        if (libro == null)
        {
            return NotFound();
        }

        context.Libro.Remove(libro);
        await context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPost("{id}/categoria")]
    [Authorize(Roles = "Administrador")]
    public async Task<IActionResult> PostCategoriaLibro(int id, AsignaGeneroDTO itemToAdd)
    {
        Genero? genero = await context.Genero.FindAsync(itemToAdd.GeneroId);
        if (genero == null) return NotFound();

        var pelicula = await context.Libro.Include(i => i.Generos).FirstOrDefaultAsync(s => s.LibroId == id);
        if (pelicula == null) return NotFound();

        if (pelicula?.Generos?.FirstOrDefault(genero) != null)
        {
            pelicula.Generos.Add(genero);
            await context.SaveChangesAsync();
        }

        return NoContent();
    }

    [HttpDelete("{id}/categoria/{categoriaid}")]
    [Authorize(Roles = "Administrador")]
    public async Task<IActionResult> DeleteGeneroPelicula(int id, int generoid)
    {
        Genero? genero = await context.Genero.FindAsync(generoid);
        if (genero == null) return NotFound();

        var libro = await context.Libro.Include(i => i.Generos).FirstOrDefaultAsync(s => s.LibroId == id);
        if (libro == null) return NotFound();

        if (libro?.Generos?.FirstOrDefault(genero) != null)
        {
            libro.Generos.Remove(genero);
            await context.SaveChangesAsync();
        }

        return NoContent();
    }
}