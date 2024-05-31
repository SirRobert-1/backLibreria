using System.Text.Json.Serialization;

namespace backendnet.Models;

public class Genero
{
    public int GeneroId { get; set; }

    public required string Nombre { get; set; }

    public bool Protegida { get; set; } = false;

    [JsonIgnore]

    public ICollection<Libro>? Libros { get; set; }
}