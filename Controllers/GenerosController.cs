using System.Data.Common;
using backendnet.Data;
using backendnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace backendnet.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Administrador")]

public class GenerosController(IdentityContext context) : Controller
{

    [HttpGet]

    public async Task<ActionResult<IEnumerable<Genero>>> GetGeneros()
    {
        return await context.Genero.AsNoTracking().ToListAsync();
    }

    [HttpGet("{id}")]

    public async Task<ActionResult<Genero>> GetGenero(int id)
    {
        var genero = await context.Genero.FindAsync(id);

        if (genero == null)
        {
            return NotFound();
        }

        return genero;
    }

    [HttpPost]

    public async Task<ActionResult<Genero>> PostGenero(GeneroDTO generoDTO)
    {
        Genero genero = new()
        {
            Nombre = generoDTO.Nombre
        };

        context.Genero.Add(genero);
        await context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetGenero), new { id = genero.GeneroId }, genero);
    }

    [HttpPut("{id}")]

    public async Task<IActionResult> PutCategoria(int id, GeneroDTO generoDTO)
    {
        if (id != generoDTO.GeneroId)
        {
            return BadRequest();
        }

        var genero = await context.Genero.FindAsync(id);
        if (genero == null)
        {
            return NotFound();
        }

        genero.Nombre = generoDTO.Nombre;

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

    public async Task<IActionResult> DeleteGenero(int id)
    {
        var genero = await context.Genero.FindAsync(id);
        if (genero == null)
        {
            return NotFound();
        }

        if (genero.Protegida)
        {
            return BadRequest();
        }

        context.Genero.Remove(genero);
        await context.SaveChangesAsync();

        return NoContent();
    }
}