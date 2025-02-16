using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class RenomearImageUrlParaImagemUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                table: "Categorias", // Nome da tabela
                name: "ImageUrl",    // Nome atual da coluna
                newName: "ImagemUrl"); // Novo nome da coluna
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                table: "Categorias", // Nome da tabela
                name: "ImagemUrl",   // Novo nome da coluna
                newName: "ImageUrl"); // Nome original da coluna
        }
    }
}
