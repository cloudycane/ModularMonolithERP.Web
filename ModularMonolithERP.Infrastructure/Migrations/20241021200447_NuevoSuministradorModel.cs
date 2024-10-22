using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModularMonolithERP.Infrastructure.Migrations
{
    public partial class NuevoSuministradorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suministradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriaProveedor = table.Column<int>(type: "int", nullable: false),
                    CondicionesPagoEnum = table.Column<int>(type: "int", nullable: false),
                    FormasPago = table.Column<int>(type: "int", nullable: false),
                    MetodosTransporte = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonedaPreferida = table.Column<int>(type: "int", nullable: false),
                    TipoProveedor = table.Column<int>(type: "int", nullable: false),
                    PaisOrigen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suministradores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suministradores");
        }
    }
}
