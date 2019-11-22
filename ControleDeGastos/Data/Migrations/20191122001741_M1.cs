using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeGastos.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orcamentos_Categorias_CategoriaID",
                table: "Orcamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Orcamentos_Mes_MesID",
                table: "Orcamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orcamentos",
                table: "Orcamentos");

            migrationBuilder.DropIndex(
                name: "IX_Orcamentos_CategoriaID",
                table: "Orcamentos");

            migrationBuilder.DropColumn(
                name: "CategoriaID",
                table: "Orcamentos");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Orcamentos");

            migrationBuilder.RenameTable(
                name: "Orcamentos",
                newName: "Orcamento");

            migrationBuilder.RenameIndex(
                name: "IX_Orcamentos_MesID",
                table: "Orcamento",
                newName: "IX_Orcamento_MesID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orcamento",
                table: "Orcamento",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "ItemOrcamento",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoriaID = table.Column<int>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    OrcamentoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrcamento", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemOrcamento_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemOrcamento_Orcamento_OrcamentoID",
                        column: x => x.OrcamentoID,
                        principalTable: "Orcamento",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrcamento_CategoriaID",
                table: "ItemOrcamento",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrcamento_OrcamentoID",
                table: "ItemOrcamento",
                column: "OrcamentoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orcamento_Mes_MesID",
                table: "Orcamento",
                column: "MesID",
                principalTable: "Mes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orcamento_Mes_MesID",
                table: "Orcamento");

            migrationBuilder.DropTable(
                name: "ItemOrcamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orcamento",
                table: "Orcamento");

            migrationBuilder.RenameTable(
                name: "Orcamento",
                newName: "Orcamentos");

            migrationBuilder.RenameIndex(
                name: "IX_Orcamento_MesID",
                table: "Orcamentos",
                newName: "IX_Orcamentos_MesID");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaID",
                table: "Orcamentos",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Orcamentos",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orcamentos",
                table: "Orcamentos",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamentos_CategoriaID",
                table: "Orcamentos",
                column: "CategoriaID");

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
    }
}
