using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModularMonolithERP.Infrastructure.Migrations
{
    public partial class SuministradorEntidadViewController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suministradores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoTransaccion = table.Column<int>(type: "int", nullable: false),
                    CIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaisOrigen = table.Column<int>(type: "int", nullable: false),
                    MonedaPreferida = table.Column<int>(type: "int", nullable: false),
                    PersonaContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SitioWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorarioAtencion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CondicionesPago = table.Column<int>(type: "int", nullable: false),
                    FormasPago = table.Column<int>(type: "int", nullable: false),
                    Descuentos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiasEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GastosEnvio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioProducto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnidadMedida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockMinimo = table.Column<int>(type: "int", nullable: false),
                    CapacidadProduccion = table.Column<int>(type: "int", nullable: false),
                    CategoriaProveedor = table.Column<int>(type: "int", nullable: false),
                    DocumentosLegales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificacionesLegales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContratoVigente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoliticasDevolucion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetodosTransporte = table.Column<int>(type: "int", nullable: false),
                    CostosLogisticos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlazosEntrega = table.Column<int>(type: "int", nullable: false),
                    FechaUltimaAuditoria = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequisitosRegulatorios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeudaActual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RiesgoProveedor = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaCompra = table.Column<int>(type: "int", nullable: false)
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
