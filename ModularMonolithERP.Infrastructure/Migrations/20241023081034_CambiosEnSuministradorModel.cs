using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModularMonolithERP.Infrastructure.Migrations
{
    public partial class CambiosEnSuministradorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suministradores_ProductosSuministradores_ProductoSuministradorId",
                table: "Suministradores");

            migrationBuilder.AlterColumn<int>(
                name: "ProductoSuministradorId",
                table: "Suministradores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Suministradores_ProductosSuministradores_ProductoSuministradorId",
                table: "Suministradores",
                column: "ProductoSuministradorId",
                principalTable: "ProductosSuministradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suministradores_ProductosSuministradores_ProductoSuministradorId",
                table: "Suministradores");

            migrationBuilder.AlterColumn<int>(
                name: "ProductoSuministradorId",
                table: "Suministradores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Suministradores_ProductosSuministradores_ProductoSuministradorId",
                table: "Suministradores",
                column: "ProductoSuministradorId",
                principalTable: "ProductosSuministradores",
                principalColumn: "Id");
        }
    }
}
