using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeGastos.Data.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrcamento_Categorias_CategoriaID",
                table: "ItemOrcamento");

            migrationBuilder.DropIndex(
                name: "IX_ItemOrcamento_CategoriaID",
                table: "ItemOrcamento");

            migrationBuilder.DropColumn(
                name: "CategoriaID",
                table: "ItemOrcamento");

            migrationBuilder.AddColumn<int>(
                name: "Categoria",
                table: "ItemOrcamento",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "ItemOrcamento");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaID",
                table: "ItemOrcamento",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrcamento_CategoriaID",
                table: "ItemOrcamento",
                column: "CategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrcamento_Categorias_CategoriaID",
                table: "ItemOrcamento",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
