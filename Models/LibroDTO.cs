namespace backendnet.Models;

public class LibroDTO
{
    public int? LibroId { get; set; }

    public required string Titulo { get; set; }

    public string Sinopsis { get; set; } = "Sin sinopsis";

    public int Anio { get; set; }

    public string Portada { get; set; } = "N/A";

    public int[]? Genero { get; set; }

}
