﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backendnet.Data;

#nullable disable

namespace backendnet.Migrations
{
    [DbContext(typeof(IdentityContext))]
    [Migration("20240531061135_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("GeneroLibro", b =>
                {
                    b.Property<int>("GenerosGeneroId")
                        .HasColumnType("int");

                    b.Property<int>("LibrosLibroId")
                        .HasColumnType("int");

                    b.HasKey("GenerosGeneroId", "LibrosLibroId");

                    b.HasIndex("LibrosLibroId");

                    b.ToTable("GeneroLibro");

                    b.HasData(
                        new
                        {
                            GenerosGeneroId = 1,
                            LibrosLibroId = 1
                        },
                        new
                        {
                            GenerosGeneroId = 2,
                            LibrosLibroId = 3
                        },
                        new
                        {
                            GenerosGeneroId = 3,
                            LibrosLibroId = 4
                        },
                        new
                        {
                            GenerosGeneroId = 4,
                            LibrosLibroId = 5
                        },
                        new
                        {
                            GenerosGeneroId = 5,
                            LibrosLibroId = 6
                        },
                        new
                        {
                            GenerosGeneroId = 6,
                            LibrosLibroId = 7
                        },
                        new
                        {
                            GenerosGeneroId = 7,
                            LibrosLibroId = 8
                        },
                        new
                        {
                            GenerosGeneroId = 8,
                            LibrosLibroId = 9
                        },
                        new
                        {
                            GenerosGeneroId = 9,
                            LibrosLibroId = 10
                        },
                        new
                        {
                            GenerosGeneroId = 10,
                            LibrosLibroId = 11
                        },
                        new
                        {
                            GenerosGeneroId = 11,
                            LibrosLibroId = 12
                        },
                        new
                        {
                            GenerosGeneroId = 12,
                            LibrosLibroId = 13
                        },
                        new
                        {
                            GenerosGeneroId = 13,
                            LibrosLibroId = 14
                        },
                        new
                        {
                            GenerosGeneroId = 14,
                            LibrosLibroId = 15
                        },
                        new
                        {
                            GenerosGeneroId = 15,
                            LibrosLibroId = 16
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6a10a6a7-f6c5-4d3b-8817-07bf9d3b1ccd",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "f6bd0439-e314-4ae7-97cd-8e20dca5fad9",
                            Name = "Usuario",
                            NormalizedName = "USUARIO"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "c0fe6b3f-5c17-4cc0-ab14-c7045bb19774",
                            RoleId = "6a10a6a7-f6c5-4d3b-8817-07bf9d3b1ccd"
                        },
                        new
                        {
                            UserId = "121c966c-fb83-465a-82bc-f6417cc9d79c",
                            RoleId = "f6bd0439-e314-4ae7-97cd-8e20dca5fad9"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("backendnet.Models.CustomIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Protegido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c0fe6b3f-5c17-4cc0-ab14-c7045bb19774",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6d892251-0e6e-4ef7-80f8-c2395dfd563e",
                            Email = "sirrobert1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Nombre = "Roberto Viveros",
                            NormalizedEmail = "SIRROBERT1@GMAIL.COM",
                            NormalizedUserName = "SIRROBERT1@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEMw7xzvTUWK53XXG4M3zwJmsxFoPW5YhGPR2RHUeSrd9+pO0HGVA131d+cJzuGaQaQ==",
                            PhoneNumberConfirmed = false,
                            Protegido = true,
                            SecurityStamp = "22959ae1-93b7-4f8c-b933-95820fd06020",
                            TwoFactorEnabled = false,
                            UserName = "sirrobert1@gmail.com"
                        },
                        new
                        {
                            Id = "121c966c-fb83-465a-82bc-f6417cc9d79c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "35a7392e-9920-4616-9760-6da6f5191201",
                            Email = "gatito@uv.mx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Nombre = "Gatito",
                            NormalizedEmail = "GATITO@UV.MX",
                            NormalizedUserName = "GATITO@UV.MX",
                            PasswordHash = "AQAAAAIAAYagAAAAEDC8ee3avjCewINDQY2rpbblF2bWMxStSlGr1lluyq/IB8ajv7hz+pN5T6yIrHh0KA==",
                            PhoneNumberConfirmed = false,
                            Protegido = false,
                            SecurityStamp = "6bece580-4050-43b9-8b34-31b70176ebf4",
                            TwoFactorEnabled = false,
                            UserName = "gatito@uv.mx"
                        });
                });

            modelBuilder.Entity("backendnet.Models.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("GeneroId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Protegida")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("GeneroId");

                    b.ToTable("Genero");

                    b.HasData(
                        new
                        {
                            GeneroId = 1,
                            Nombre = "Ciberpunk",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 2,
                            Nombre = "Steampunk",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 3,
                            Nombre = "Poesía",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 4,
                            Nombre = "Ciencia ficción",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 5,
                            Nombre = "Thriller",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 6,
                            Nombre = "Distopia",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 7,
                            Nombre = "Biografía",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 8,
                            Nombre = "Autobiografía",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 9,
                            Nombre = "Belica",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 10,
                            Nombre = "Fantasia",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 11,
                            Nombre = "Aventura",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 12,
                            Nombre = "Terror",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 13,
                            Nombre = "Epica",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 14,
                            Nombre = "Misterio",
                            Protegida = true
                        },
                        new
                        {
                            GeneroId = 15,
                            Nombre = "Romance",
                            Protegida = true
                        });
                });

            modelBuilder.Entity("backendnet.Models.Libro", b =>
                {
                    b.Property<int>("LibroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("LibroId"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<string>("Portada")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("LibroId");

                    b.ToTable("Libro");

                    b.HasData(
                        new
                        {
                            LibroId = 1,
                            Anio = 1984,
                            Portada = "https://m.media-amazon.com/images/I/818Y1vupv0L._AC_UF1000,1000_QL80_.jpg",
                            Sinopsis = "Un hacker intenta realizar el último trabajo que le permitirá volver a su vida anterior, en un futuro distópico dominado por megacorporaciones.",
                            Titulo = "Neuromante"
                        },
                        new
                        {
                            LibroId = 2,
                            Anio = 1990,
                            Portada = "https://i.pinimg.com/originals/04/bf/c6/04bfc6dc6c10e690be25037a61b00732.jpg",
                            Sinopsis = "Novela ambientada en una versión alternativa del siglo XIX donde Charles Babbage ha construido una computadora mecánica avanzada.",
                            Titulo = "La máquina diferencial"
                        },
                        new
                        {
                            LibroId = 3,
                            Anio = 1924,
                            Portada = "https://assets-global.website-files.com/6034d7d1f3e0f52c50b2adee/625453f86f695c42fd66a883_6228e16ec46732b86f7d1aa0_9788418395796.jpeg",
                            Sinopsis = "Una colección de poemas que expresan el amor, la pasión y la desesperación",
                            Titulo = "Veinte poemas de amor y una canción desesperada"
                        },
                        new
                        {
                            LibroId = 4,
                            Anio = 1949,
                            Portada = "https://m.media-amazon.com/images/I/61NAx5pd6XL._AC_UF1000,1000_QL80_.jpg",
                            Sinopsis = "Una distopía donde un régimen totalitario controla todos los aspectos de la vida y el pensamiento.",
                            Titulo = "1984"
                        },
                        new
                        {
                            LibroId = 5,
                            Anio = 1988,
                            Portada = "https://www.elsotano.com/imagenes/9786073/978607383029.JPG",
                            Sinopsis = "La agente del FBI Clarice Starling busca la ayuda del encarcelado asesino en serie Hannibal Lecter para capturar a otro asesino en serie.",
                            Titulo = "El silencio de los inocentes"
                        },
                        new
                        {
                            LibroId = 6,
                            Anio = 1932,
                            Portada = "https://4.bp.blogspot.com/-g7Pd0hl5Y-Q/VJ7Oqi4VPBI/AAAAAAAAAag/taFFkbW89js/s1600/un-mundo-feliz-aldous-huxley-garbayo.jpg",
                            Sinopsis = "Una novela que presenta una sociedad futura controlada por el estado, donde la libertad individual es sacrificada por la estabilidad social.",
                            Titulo = "Un mundo feliz"
                        },
                        new
                        {
                            LibroId = 7,
                            Anio = 2011,
                            Portada = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1657289185i/61409936.jpg",
                            Sinopsis = " La biografía autorizada de Steve Jobs, cofundador de Apple, explorando su vida personal y profesional.",
                            Titulo = "Steve Jobs"
                        },
                        new
                        {
                            LibroId = 8,
                            Anio = 1946,
                            Portada = "https://m.media-amazon.com/images/I/71dWcI94iPS._AC_UF894,1000_QL80_.jpg",
                            Sinopsis = "El diario personal de una joven judía escondida durante la ocupación nazi en los Países Bajos.",
                            Titulo = "El diario de Ana Frank"
                        },
                        new
                        {
                            LibroId = 9,
                            Anio = 1929,
                            Portada = "https://images.cdn3.buscalibre.com/fit-in/360x360/2f/5a/2f5a03a2da31ad73fdce2a1f730dd9a4.jpg",
                            Sinopsis = "Describe las duras realidades de la vida en las trincheras durante la Primera Guerra Mundial a través de los ojos de un joven soldado alemán.",
                            Titulo = "Sin novedad en el frente"
                        },
                        new
                        {
                            LibroId = 10,
                            Anio = 1954,
                            Portada = "https://imagessl8.casadellibro.com/a/l/t0/98/9788445077498.jpg",
                            Sinopsis = " La primera parte de una épica trilogía sobre la lucha contra el mal en la Tierra Media.",
                            Titulo = "El señor de los anillos: La comunidad del anillo"
                        },
                        new
                        {
                            LibroId = 11,
                            Anio = 1883,
                            Portada = "https://manresalibros.com/wp-content/uploads/2022/01/la-isla-del-tesoro-e1643330787461.jpeg",
                            Sinopsis = "La historia sigue las aventuras del joven Jim Hawkins y su búsqueda de un tesoro pirata en una isla remota.",
                            Titulo = "La isla del tesoro"
                        },
                        new
                        {
                            LibroId = 12,
                            Anio = 1897,
                            Portada = "https://www.popularlibros.com/imagenes_grandes/9788444/978844414586.JPG",
                            Sinopsis = "La historia del conde Drácula y su intento de mudarse a Inglaterra para propagar el mal.",
                            Titulo = "Dracula"
                        },
                        new
                        {
                            LibroId = 13,
                            Anio = 700,
                            Portada = "https://www.loqueleo.com/bo/uploads/2016/12/resized/800_la-odisea.jpg",
                            Sinopsis = "Poema épico que narra las aventuras de Odiseo en su largo viaje de regreso a Ítaca después de la guerra de Troya.",
                            Titulo = "La Odisea"
                        },
                        new
                        {
                            LibroId = 14,
                            Anio = 1926,
                            Portada = "https://resources.sanborns.com.mx/imagenes-sanborns-ii/1200/9786070790096_2.jpg?scale=500&qlty=75",
                            Sinopsis = "El detective Hercule Poirot investiga el asesinato de Roger Ackroyd en un pequeño pueblo inglés.",
                            Titulo = "El asesinato de Roger Ackroyd"
                        },
                        new
                        {
                            LibroId = 15,
                            Anio = 1813,
                            Portada = "https://www.popularlibros.com/imagenes_grandes/9788420/978842067518.JPG",
                            Sinopsis = "La historia de Elizabeth Bennet y su complicada relación con el orgulloso Sr. Darcy.",
                            Titulo = "Orgullo y prejuicio"
                        });
                });

            modelBuilder.Entity("GeneroLibro", b =>
                {
                    b.HasOne("backendnet.Models.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosGeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendnet.Models.Libro", null)
                        .WithMany()
                        .HasForeignKey("LibrosLibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
