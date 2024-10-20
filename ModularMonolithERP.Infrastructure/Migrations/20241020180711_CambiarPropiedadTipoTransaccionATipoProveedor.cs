using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModularMonolithERP.Infrastructure.Migrations
{
    public partial class CambiarPropiedadTipoTransaccionATipoProveedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoTransaccion",
                table: "Suministradores",
                newName: "TipoProveedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoProveedor",
                table: "Suministradores",
                newName: "TipoTransaccion");
        }
    }
}
