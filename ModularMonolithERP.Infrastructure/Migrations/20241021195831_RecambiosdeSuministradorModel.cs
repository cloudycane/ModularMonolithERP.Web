using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModularMonolithERP.Infrastructure.Migrations
{
    public partial class RecambiosdeSuministradorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suministradores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suministradores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapacidadProduccion = table.Column<int>(type: "int", nullable: false),
                    CategoriaProveedor = table.Column<int>(type: "int", nullable: false),
                    CertificacionesLegales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CondicionesPago = table.Column<int>(type: "int", nullable: false),
                    ContratoVigente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostosLogisticos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descuentos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeudaActual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiasEntrega = table.Column<int>(type: "int", nullable: false),
                    DireccionFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentosLegales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaAuditoria = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormasPago = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaCompra = table.Column<int>(type: "int", nullable: false),
                    GastosEnvio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HorarioAtencion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MetodosTransporte = table.Column<int>(type: "int", nullable: false),
                    MonedaPreferida = table.Column<int>(type: "int", nullable: false),
                    PaisOrigen = table.Column<int>(type: "int", nullable: false),
                    PersonaContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlazosEntrega = table.Column<int>(type: "int", nullable: false),
                    PoliticasDevolucion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioProducto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequisitosRegulatorios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiesgoProveedor = table.Column<int>(type: "int", nullable: false),
                    SitioWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockMinimo = table.Column<int>(type: "int", nullable: false),
                    TelefonoContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoProveedor = table.Column<int>(type: "int", nullable: false),
                    UnidadMedida = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suministradores", x => x.Id);
                });
        }
    }
}
