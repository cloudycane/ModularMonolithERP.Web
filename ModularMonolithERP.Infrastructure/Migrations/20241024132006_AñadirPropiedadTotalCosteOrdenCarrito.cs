using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModularMonolithERP.Infrastructure.Migrations
{
    public partial class AñadirPropiedadTotalCosteOrdenCarrito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalCoste",
                table: "OrdenesCarritos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCoste",
                table: "OrdenesCarritos");
        }
    }
}
