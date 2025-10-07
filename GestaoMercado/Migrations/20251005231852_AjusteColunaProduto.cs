using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoMercado.Migrations
{
    /// <inheritdoc />
    public partial class AjusteColunaProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecoVenda",
                table: "Produto",
                newName: "Custo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Custo",
                table: "Produto",
                newName: "PrecoVenda");
        }
    }
}
