using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModularMonolithERP.Infrastructure.Migrations
{
    public partial class CambiarProductoIdAProductoSuministradorIdEnOrdenCarritoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdenesCarritos_ProductosSuministradores_ProductoSuministradorId",
                table: "OrdenesCarritos");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "OrdenesCarritos");

            migrationBuilder.AlterColumn<int>(
                name: "ProductoSuministradorId",
                table: "OrdenesCarritos",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenesCarritos_ProductosSuministradores_ProductoSuministradorId",
                table: "OrdenesCarritos",
                column: "ProductoSuministradorId",
                principalTable: "ProductosSuministradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdenesCarritos_ProductosSuministradores_ProductoSuministradorId",
                table: "OrdenesCarritos");

            migrationBuilder.AlterColumn<int>(
                name: "ProductoSuministradorId",
                table: "OrdenesCarritos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "OrdenesCarritos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenesCarritos_ProductosSuministradores_ProductoSuministradorId",
                table: "OrdenesCarritos",
                column: "ProductoSuministradorId",
                principalTable: "ProductosSuministradores",
                principalColumn: "Id");
        }
    }
}
