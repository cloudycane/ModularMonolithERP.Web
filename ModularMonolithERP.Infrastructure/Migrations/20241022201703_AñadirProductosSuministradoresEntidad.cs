using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModularMonolithERP.Infrastructure.Migrations
{
    public partial class AñadirProductosSuministradoresEntidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductoSuministradorId",
                table: "Suministradores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductosSuministradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CosteProducto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CantidadProducto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosSuministradores", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suministradores_ProductoSuministradorId",
                table: "Suministradores",
                column: "ProductoSuministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suministradores_ProductosSuministradores_ProductoSuministradorId",
                table: "Suministradores",
                column: "ProductoSuministradorId",
                principalTable: "ProductosSuministradores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suministradores_ProductosSuministradores_ProductoSuministradorId",
                table: "Suministradores");

            migrationBuilder.DropTable(
                name: "ProductosSuministradores");

            migrationBuilder.DropIndex(
                name: "IX_Suministradores_ProductoSuministradorId",
                table: "Suministradores");

            migrationBuilder.DropColumn(
                name: "ProductoSuministradorId",
                table: "Suministradores");
        }
    }
}
