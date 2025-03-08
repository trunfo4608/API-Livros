using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LivrosAPP.Service.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AUTOR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUTOR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIVRO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GENERO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EDITORA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TITULO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VAlOR = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AUTORID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIVRO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LIVRO_AUTOR_AUTORID",
                        column: x => x.AUTORID,
                        principalTable: "AUTOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AUTOR_NOME",
                table: "AUTOR",
                column: "NOME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LIVRO_AUTORID",
                table: "LIVRO",
                column: "AUTORID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LIVRO");

            migrationBuilder.DropTable(
                name: "AUTOR");
        }
    }
}
