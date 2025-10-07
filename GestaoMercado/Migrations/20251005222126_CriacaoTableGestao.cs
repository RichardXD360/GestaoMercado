using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoMercado.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoTableGestao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecoVenda",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Gestao",
                columns: table => new
                {
                    NomeGestor = table.Column<string>(type: "TEXT", nullable: false),
                    Saldo = table.Column<decimal>(type: "TEXT", nullable: false),
                    Lucro = table.Column<decimal>(type: "TEXT", nullable: false),
                    Gasto = table.Column<decimal>(type: "TEXT", nullable: false),
                    NumVendas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gestao");

            migrationBuilder.DropColumn(
                name: "PrecoVenda",
                table: "Produto");
        }
    }
}
