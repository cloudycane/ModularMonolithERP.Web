using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModularMonolithERP.Infrastructure.Migrations
{
    public partial class CambiosEnTransaccionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Concepto",
                table: "Transacciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoGasto",
                table: "Transacciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoIngreso",
                table: "Transacciones",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoGasto",
                table: "Transacciones");

            migrationBuilder.DropColumn(
                name: "TipoIngreso",
                table: "Transacciones");

            migrationBuilder.AlterColumn<string>(
                name: "Concepto",
                table: "Transacciones",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
