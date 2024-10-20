using ModularMonolithERP.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Entidades
{
    public class SuministradorModel
    {
        public Guid Id { get; set; }
        public string RazonSocial { get; set; }
        public TipoProveedorEnum TipoProveedor { get; set; }
        public string CIF { get; set; }
        public DateTime FechaRegistro { get; set; }
        // Cambiar esto por enum 
        public PaisOrigenEnum PaisOrigen {  get; set; }
        // Cambiar esto por enum 
        public MonedaPreferidaEnum MonedaPreferida { get; set; }
        public string PersonaContacto { get; set; }
        public string TelefonoContacto { get; set; }
        public string EmailContacto { get; set; }
        public string DireccionFiscal { get; set; }
        public string SitioWeb { get; set; }
        public DateTime HorarioAtencion { get; set; }
        // Cambiar esto por enum 
        public CondicionesPagoEnum CondicionesPago { get; set; }
        // Cambiar esto por enum 
        public FormasPagoEnum FormasPago { get; set; }
        public string Descuentos {  get; set; }
        public int DiasEntrega { get; set; }
        public decimal GastosEnvio { get; set; }
        // Nav Property CatalogoProductos de Proveedor o Suministrador
        public decimal PrecioProducto { get; set; }
        public string UnidadMedida { get; set; }
        public int StockMinimo { get; set; }
        public int CapacidadProduccion {  get; set; }
        // enum 
        public CategoriaProveedorEnum CategoriaProveedor {  get; set; }
        //public int CalificacionProveedor { get; set; }
        //public int EvaluacionesAnteriores {  get; set; }
        // Lista PedidosHistoricos
        //public string PedidosHistoricos { get; set; }
        // Lista Penalizaciones 
        //public string Penalizaciones {  get; set; }
        // Documentos 
        public string DocumentosLegales { get; set; }
        public string CertificacionesLegales { get; set; }
        public string ContratoVigente { get; set; }
        public string PoliticasDevolucion { get; set; }
        // Enum Transporte 
        public MetodosTransporteEnum MetodosTransporte { get; set; }
        // Enum Entrega 
        //public string ZonasEntrega { get; set; }
        public decimal CostosLogisticos { get; set; }
        public int PlazosEntrega { get; set; }
        // Enum Normativas Cumplidas 
        //public string NormativasCumplidas { get; set; }
        public DateTime FechaUltimaAuditoria { get; set; }
        public string RequisitosRegulatorios { get; set; }
        // Lista Historial Financiero y Riesgos 
        //public string HistorialPagos { get; set; }
        public decimal DeudaActual { get; set; }
        // Nivel de riesgo asociado con el proveedor basado en su historial financiero
        public int RiesgoProveedor { get; set; }
        public int FrecuenciaCompra {  get; set; }

    }
}
