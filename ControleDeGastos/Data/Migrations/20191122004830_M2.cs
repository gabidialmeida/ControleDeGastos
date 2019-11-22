using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeGastos.Data.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrcamento_Orcamento_OrcamentoID",
                table: "ItemOrcamento");

            migrationBuilder.RenameColumn(
                name: "OrcamentoID",
                table: "ItemOrcamento",
                newName: "Orcamento");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrcamento_Orcamento",
                table: "ItemOrcamento",
                column: "Orcamento");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrcamento_Orcamento_Orcamento",
                table: "ItemOrcamento",
                column: "Orcamento",
                principalTable: "Orcamento",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrcamento_Orcamento_Orcamento",
                table: "ItemOrcamento");

            migrationBuilder.DropIndex(
                name: "IX_ItemOrcamento_Orcamento",
                table: "ItemOrcamento");

            migrationBuilder.RenameColumn(
                name: "Orcamento",
                table: "ItemOrcamento",
                newName: "OrcamentoID");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrcamento_Orcamento_OrcamentoID",
                table: "ItemOrcamento",
                column: "OrcamentoID",
                principalTable: "Orcamento",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
