using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeGastos.Data.Migrations
{
    public partial class Contas1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Gastos");

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Orcamentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaID",
                table: "Orcamentos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Orcamentos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MesID",
                table: "Orcamentos",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Orcamentos",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Gastos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MesID",
                table: "Gastos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Mes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    mes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orcamentos_CategoriaID",
                table: "Orcamentos",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamentos_MesID",
                table: "Orcamentos",
                column: "MesID");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_MesID",
                table: "Gastos",
                column: "MesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Mes_MesID",
                table: "Gastos",
                column: "MesID",
                principalTable: "Mes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orcamentos_Categorias_CategoriaID",
                table: "Orcamentos",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orcamentos_Mes_MesID",
                table: "Orcamentos",
                column: "MesID",
                principalTable: "Mes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Mes_MesID",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Orcamentos_Categorias_CategoriaID",
                table: "Orcamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Orcamentos_Mes_MesID",
                table: "Orcamentos");

            migrationBuilder.DropTable(
                name: "Mes");

            migrationBuilder.DropIndex(
                name: "IX_Orcamentos_CategoriaID",
                table: "Orcamentos");

            migrationBuilder.DropIndex(
                name: "IX_Orcamentos_MesID",
                table: "Orcamentos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_MesID",
                table: "Gastos");

            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Orcamentos");

            migrationBuilder.DropColumn(
                name: "CategoriaID",
                table: "Orcamentos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Orcamentos");

            migrationBuilder.DropColumn(
                name: "MesID",
                table: "Orcamentos");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Orcamentos");

            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Gastos");

            migrationBuilder.DropColumn(
                name: "MesID",
                table: "Gastos");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Gastos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
