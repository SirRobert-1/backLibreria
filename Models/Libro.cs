namespace backendnet.Models;

public class Libro
{
    public int LibroId { get; set; }

    public string Titulo { get; set; } = "Sin título";

    public string Sinopsis { get; set; } = "Sin sinopsis";

    public int Anio { get; set; }

    public string Portada { get; set; } = "N/A";

    public ICollection<Genero>? Generos { get; set; }
}