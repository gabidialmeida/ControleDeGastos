using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeGastos.Data.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContaID",
                table: "Gastos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_ContaID",
                table: "Gastos",
                column: "ContaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Contas_ContaID",
                table: "Gastos",
                column: "ContaID",
                principalTable: "Contas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Contas_ContaID",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_ContaID",
                table: "Gastos");

            migrationBuilder.DropColumn(
                name: "ContaID",
                table: "Gastos");
        }
    }
}
