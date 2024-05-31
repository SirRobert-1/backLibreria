using backendnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backendnet.Data.Seed;

public class SeedLibro : IEntityTypeConfiguration<Libro>
{
    public void Configure(EntityTypeBuilder<Libro> builder)
    {
        builder.HasData(
            new Libro { LibroId = 1, Titulo = "Neuromante", Sinopsis = "Un hacker intenta realizar el último trabajo que le permitirá volver a su vida anterior, en un futuro distópico dominado por megacorporaciones.", Anio = 1984, Portada = "https://m.media-amazon.com/images/I/818Y1vupv0L._AC_UF1000,1000_QL80_.jpg" },
            new Libro { LibroId = 2, Titulo = "La máquina diferencial", Sinopsis = "Novela ambientada en una versión alternativa del siglo XIX donde Charles Babbage ha construido una computadora mecánica avanzada.", Anio = 1990, Portada = "https://i.pinimg.com/originals/04/bf/c6/04bfc6dc6c10e690be25037a61b00732.jpg" },
            new Libro { LibroId = 3, Titulo = "Veinte poemas de amor y una canción desesperada", Sinopsis = "Una colección de poemas que expresan el amor, la pasión y la desesperación", Anio = 1924, Portada = "https://assets-global.website-files.com/6034d7d1f3e0f52c50b2adee/625453f86f695c42fd66a883_6228e16ec46732b86f7d1aa0_9788418395796.jpeg" },
            new Libro { LibroId = 4, Titulo = "1984", Sinopsis = "Una distopía donde un régimen totalitario controla todos los aspectos de la vida y el pensamiento.", Anio = 1949, Portada = "https://m.media-amazon.com/images/I/61NAx5pd6XL._AC_UF1000,1000_QL80_.jpg" },
            new Libro { LibroId = 5, Titulo = "El silencio de los inocentes", Sinopsis = "La agente del FBI Clarice Starling busca la ayuda del encarcelado asesino en serie Hannibal Lecter para capturar a otro asesino en serie.", Anio = 1988, Portada = "https://www.elsotano.com/imagenes/9786073/978607383029.JPG" },
            new Libro { LibroId = 6, Titulo = "Un mundo feliz", Sinopsis = "Una novela que presenta una sociedad futura controlada por el estado, donde la libertad individual es sacrificada por la estabilidad social.", Anio = 1932, Portada = "https://4.bp.blogspot.com/-g7Pd0hl5Y-Q/VJ7Oqi4VPBI/AAAAAAAAAag/taFFkbW89js/s1600/un-mundo-feliz-aldous-huxley-garbayo.jpg" },
            new Libro { LibroId = 7, Titulo = "Steve Jobs", Sinopsis = " La biografía autorizada de Steve Jobs, cofundador de Apple, explorando su vida personal y profesional.", Anio = 2011, Portada = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1657289185i/61409936.jpg" },
            new Libro { LibroId = 8, Titulo = "El diario de Ana Frank", Sinopsis = "El diario personal de una joven judía escondida durante la ocupación nazi en los Países Bajos.", Anio = 1946, Portada = "https://m.media-amazon.com/images/I/71dWcI94iPS._AC_UF894,1000_QL80_.jpg" },
            new Libro { LibroId = 9, Titulo = "Sin novedad en el frente", Sinopsis = "Describe las duras realidades de la vida en las trincheras durante la Primera Guerra Mundial a través de los ojos de un joven soldado alemán.", Anio = 1929, Portada = "https://images.cdn3.buscalibre.com/fit-in/360x360/2f/5a/2f5a03a2da31ad73fdce2a1f730dd9a4.jpg" },
            new Libro { LibroId = 10, Titulo = "El señor de los anillos: La comunidad del anillo", Sinopsis = " La primera parte de una épica trilogía sobre la lucha contra el mal en la Tierra Media.", Anio = 1954, Portada = "https://imagessl8.casadellibro.com/a/l/t0/98/9788445077498.jpg" },
            new Libro { LibroId = 11, Titulo = "La isla del tesoro", Sinopsis = "La historia sigue las aventuras del joven Jim Hawkins y su búsqueda de un tesoro pirata en una isla remota.", Anio = 1883, Portada = "https://manresalibros.com/wp-content/uploads/2022/01/la-isla-del-tesoro-e1643330787461.jpeg" },
            new Libro { LibroId = 12, Titulo = "Dracula", Sinopsis = "La historia del conde Drácula y su intento de mudarse a Inglaterra para propagar el mal.", Anio = 1897, Portada = "https://www.popularlibros.com/imagenes_grandes/9788444/978844414586.JPG" },
            new Libro { LibroId = 13, Titulo = "La Odisea", Sinopsis = "Poema épico que narra las aventuras de Odiseo en su largo viaje de regreso a Ítaca después de la guerra de Troya.", Anio = 700, Portada = "https://www.loqueleo.com/bo/uploads/2016/12/resized/800_la-odisea.jpg" },
            new Libro { LibroId = 14, Titulo = "El asesinato de Roger Ackroyd", Sinopsis = "El detective Hercule Poirot investiga el asesinato de Roger Ackroyd en un pequeño pueblo inglés.", Anio = 1926, Portada = "https://resources.sanborns.com.mx/imagenes-sanborns-ii/1200/9786070790096_2.jpg?scale=500&qlty=75" },
            new Libro { LibroId = 15, Titulo = "Orgullo y prejuicio", Sinopsis = "La historia de Elizabeth Bennet y su complicada relación con el orgulloso Sr. Darcy.", Anio = 1813, Portada = "https://www.popularlibros.com/imagenes_grandes/9788420/978842067518.JPG" }
        );

        // Agrega las categorias a cada película
        builder.HasMany(c => c.Generos).WithMany(c => c.Libros).UsingEntity(j => j.HasData(
            new { LibrosLibroId = 1, GenerosGeneroId = 1 },
            new { LibrosLibroId = 2, GenerosGeneroId = 2 },
            new { LibrosLibroId = 3, GenerosGeneroId = 3 },
            new { LibrosLibroId = 4, GenerosGeneroId = 4 },
            new { LibrosLibroId = 5, GenerosGeneroId = 5 },
            new { LibrosLibroId = 6, GenerosGeneroId = 6 },
            new { LibrosLibroId = 7, GenerosGeneroId = 7 },
            new { LibrosLibroId = 8, GenerosGeneroId = 8 },
            new { LibrosLibroId = 9, GenerosGeneroId = 9 },
            new { LibrosLibroId = 10, GenerosGeneroId = 10 },
            new { LibrosLibroId = 11, GenerosGeneroId = 11 },
            new { LibrosLibroId = 12, GenerosGeneroId = 12 },
            new { LibrosLibroId = 13, GenerosGeneroId = 13 },
            new { LibrosLibroId = 14, GenerosGeneroId = 14 },
            new { LibrosLibroId = 15, GenerosGeneroId = 15 }
        ));
    }
}