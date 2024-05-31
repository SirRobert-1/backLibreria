using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backendnet.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Protegido = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Protegida = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.GeneroId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    LibroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sinopsis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Portada = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.LibroId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GeneroLibro",
                columns: table => new
                {
                    GenerosGeneroId = table.Column<int>(type: "int", nullable: false),
                    LibrosLibroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroLibro", x => new { x.GenerosGeneroId, x.LibrosLibroId });
                    table.ForeignKey(
                        name: "FK_GeneroLibro_Genero_GenerosGeneroId",
                        column: x => x.GenerosGeneroId,
                        principalTable: "Genero",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroLibro_Libro_LibrosLibroId",
                        column: x => x.LibrosLibroId,
                        principalTable: "Libro",
                        principalColumn: "LibroId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a10a6a7-f6c5-4d3b-8817-07bf9d3b1ccd", null, "Administrador", "ADMINISTRADOR" },
                    { "f6bd0439-e314-4ae7-97cd-8e20dca5fad9", null, "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Protegido", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "121c966c-fb83-465a-82bc-f6417cc9d79c", 0, "35a7392e-9920-4616-9760-6da6f5191201", "gatito@uv.mx", false, false, null, "Gatito", "GATITO@UV.MX", "GATITO@UV.MX", "AQAAAAIAAYagAAAAEDC8ee3avjCewINDQY2rpbblF2bWMxStSlGr1lluyq/IB8ajv7hz+pN5T6yIrHh0KA==", null, false, false, "6bece580-4050-43b9-8b34-31b70176ebf4", false, "gatito@uv.mx" },
                    { "c0fe6b3f-5c17-4cc0-ab14-c7045bb19774", 0, "6d892251-0e6e-4ef7-80f8-c2395dfd563e", "sirrobert1@gmail.com", false, false, null, "Roberto Viveros", "SIRROBERT1@GMAIL.COM", "SIRROBERT1@GMAIL.COM", "AQAAAAIAAYagAAAAEMw7xzvTUWK53XXG4M3zwJmsxFoPW5YhGPR2RHUeSrd9+pO0HGVA131d+cJzuGaQaQ==", null, false, true, "22959ae1-93b7-4f8c-b933-95820fd06020", false, "sirrobert1@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "GeneroId", "Nombre", "Protegida" },
                values: new object[,]
                {
                    { 1, "Ciberpunk", true },
                    { 2, "Steampunk", true },
                    { 3, "Poesía", true },
                    { 4, "Ciencia ficción", true },
                    { 5, "Thriller", true },
                    { 6, "Distopia", true },
                    { 7, "Biografía", true },
                    { 8, "Autobiografía", true },
                    { 9, "Belica", true },
                    { 10, "Fantasia", true },
                    { 11, "Aventura", true },
                    { 12, "Terror", true },
                    { 13, "Epica", true },
                    { 14, "Misterio", true },
                    { 15, "Romance", true }
                });

            migrationBuilder.InsertData(
                table: "Libro",
                columns: new[] { "LibroId", "Anio", "Portada", "Sinopsis", "Titulo" },
                values: new object[,]
                {
                    { 1, 1984, "https://m.media-amazon.com/images/I/818Y1vupv0L._AC_UF1000,1000_QL80_.jpg", "Un hacker intenta realizar el último trabajo que le permitirá volver a su vida anterior, en un futuro distópico dominado por megacorporaciones.", "Neuromante" },
                    { 2, 1990, "https://i.pinimg.com/originals/04/bf/c6/04bfc6dc6c10e690be25037a61b00732.jpg", "Novela ambientada en una versión alternativa del siglo XIX donde Charles Babbage ha construido una computadora mecánica avanzada.", "La máquina diferencial" },
                    { 3, 1924, "https://assets-global.website-files.com/6034d7d1f3e0f52c50b2adee/625453f86f695c42fd66a883_6228e16ec46732b86f7d1aa0_9788418395796.jpeg", "Una colección de poemas que expresan el amor, la pasión y la desesperación", "Veinte poemas de amor y una canción desesperada" },
                    { 4, 1949, "https://m.media-amazon.com/images/I/61NAx5pd6XL._AC_UF1000,1000_QL80_.jpg", "Una distopía donde un régimen totalitario controla todos los aspectos de la vida y el pensamiento.", "1984" },
                    { 5, 1988, "https://www.elsotano.com/imagenes/9786073/978607383029.JPG", "La agente del FBI Clarice Starling busca la ayuda del encarcelado asesino en serie Hannibal Lecter para capturar a otro asesino en serie.", "El silencio de los inocentes" },
                    { 6, 1932, "https://4.bp.blogspot.com/-g7Pd0hl5Y-Q/VJ7Oqi4VPBI/AAAAAAAAAag/taFFkbW89js/s1600/un-mundo-feliz-aldous-huxley-garbayo.jpg", "Una novela que presenta una sociedad futura controlada por el estado, donde la libertad individual es sacrificada por la estabilidad social.", "Un mundo feliz" },
                    { 7, 2011, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1657289185i/61409936.jpg", " La biografía autorizada de Steve Jobs, cofundador de Apple, explorando su vida personal y profesional.", "Steve Jobs" },
                    { 8, 1946, "https://m.media-amazon.com/images/I/71dWcI94iPS._AC_UF894,1000_QL80_.jpg", "El diario personal de una joven judía escondida durante la ocupación nazi en los Países Bajos.", "El diario de Ana Frank" },
                    { 9, 1929, "https://images.cdn3.buscalibre.com/fit-in/360x360/2f/5a/2f5a03a2da31ad73fdce2a1f730dd9a4.jpg", "Describe las duras realidades de la vida en las trincheras durante la Primera Guerra Mundial a través de los ojos de un joven soldado alemán.", "Sin novedad en el frente" },
                    { 10, 1954, "https://imagessl8.casadellibro.com/a/l/t0/98/9788445077498.jpg", " La primera parte de una épica trilogía sobre la lucha contra el mal en la Tierra Media.", "El señor de los anillos: La comunidad del anillo" },
                    { 11, 1883, "https://manresalibros.com/wp-content/uploads/2022/01/la-isla-del-tesoro-e1643330787461.jpeg", "La historia sigue las aventuras del joven Jim Hawkins y su búsqueda de un tesoro pirata en una isla remota.", "La isla del tesoro" },
                    { 12, 1897, "https://www.popularlibros.com/imagenes_grandes/9788444/978844414586.JPG", "La historia del conde Drácula y su intento de mudarse a Inglaterra para propagar el mal.", "Dracula" },
                    { 13, 700, "https://www.loqueleo.com/bo/uploads/2016/12/resized/800_la-odisea.jpg", "Poema épico que narra las aventuras de Odiseo en su largo viaje de regreso a Ítaca después de la guerra de Troya.", "La Odisea" },
                    { 14, 1926, "https://resources.sanborns.com.mx/imagenes-sanborns-ii/1200/9786070790096_2.jpg?scale=500&qlty=75", "El detective Hercule Poirot investiga el asesinato de Roger Ackroyd en un pequeño pueblo inglés.", "El asesinato de Roger Ackroyd" },
                    { 15, 1813, "https://www.popularlibros.com/imagenes_grandes/9788420/978842067518.JPG", "La historia de Elizabeth Bennet y su complicada relación con el orgulloso Sr. Darcy.", "Orgullo y prejuicio" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f6bd0439-e314-4ae7-97cd-8e20dca5fad9", "121c966c-fb83-465a-82bc-f6417cc9d79c" },
                    { "6a10a6a7-f6c5-4d3b-8817-07bf9d3b1ccd", "c0fe6b3f-5c17-4cc0-ab14-c7045bb19774" }
                });

            migrationBuilder.InsertData(
                table: "GeneroLibro",
                columns: new[] { "GenerosGeneroId", "LibrosLibroId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 3 },
                    { 3, 4 },
                    { 4, 5 },
                    { 5, 6 },
                    { 6, 7 },
                    { 7, 8 },
                    { 8, 9 },
                    { 9, 10 },
                    { 10, 11 },
                    { 11, 12 },
                    { 12, 13 },
                    { 13, 14 },
                    { 14, 15 },
                    { 15, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GeneroLibro_LibrosLibroId",
                table: "GeneroLibro",
                column: "LibrosLibroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GeneroLibro");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Libro");
        }
    }
}
