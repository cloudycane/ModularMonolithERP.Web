using ModularMonolithERP.Core.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModularMonolithERP.Web.ViewModels
{
    public class SuministradorViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(100)]
        [DisplayName("Razón Social")]
        public string RazonSocial { get; set; }

        [DisplayName("Tipo de Transacción")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public TipoProveedorEnum TipoProveedor { get; set; }
        [Required]
        [DisplayName("NIF/CIF")]
        public string CIF { get; set; }
        [Required]
        [DisplayName("Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [DisplayName("País de Origen")]
        // Cambiar esto por enum 
        public PaisOrigenEnum PaisOrigen { get; set; }
        [Required]
        [DisplayName("Moneda")]
        // Cambiar esto por enum 
        public MonedaPreferidaEnum MonedaPreferida { get; set; }
        [Required]
        [DisplayName("Persona de Contacto")]
        public string PersonaContacto { get; set; }
        [Required]
        [DisplayName("Télefono de Contacto")]
        public string TelefonoContacto { get; set; }
        [Required]
        [DisplayName("Correo Electrónico")]
        public string EmailContacto { get; set; }
        [Required]
        [DisplayName("Dirección Fiscal")]
        public string DireccionFiscal { get; set; }
        [Required]
        [DisplayName("Sitio Web")]
        public string SitioWeb { get; set; }
        [Required]
        [DisplayName("Horario Atención")]
        public DateTime HorarioAtencion { get; set; }
        [Required]
        [DisplayName("Condiciones de Pago")]
        // Cambiar esto por enum 
        public CondicionesPagoEnum CondicionesPago { get; set; }
        [Required]
        [DisplayName("Formas de Pago")]
        // Cambiar esto por enum 
        public FormasPagoEnum FormasPago { get; set; }
        [Required]
        [DisplayName("Descuentos")]
        public string Descuentos { get; set; }
        [Required]
        [DisplayName("Días de Entrega")]
        public int DiasEntrega { get; set; }
        [Required]
        [DisplayName("Gastos de Envío")]
        public decimal GastosEnvio { get; set; }
        // Nav Property CatalogoProductos de Proveedor o Suministrador
        [Required]
        [DisplayName("Precio de Producto")]
        public decimal PrecioProducto { get; set; }
        [Required]
        [DisplayName("Unidad de Medida")]
        public string UnidadMedida { get; set; }
        [Required]
        [DisplayName("Stock Mínimo")]
        public int StockMinimo { get; set; }
        [Required]
        [DisplayName("Capacidad de Producción")]
        public int CapacidadProduccion { get; set; }
        // enum 
        [Required]
        [DisplayName("Categoría de Proveedor")]
        public CategoriaProveedorEnum CategoriaProveedor { get; set; }
        //public int CalificacionProveedor { get; set; }
        //public int EvaluacionesAnteriores {  get; set; }
        // Lista PedidosHistoricos
        //public string PedidosHistoricos { get; set; }
        // Lista Penalizaciones 
        //public string Penalizaciones {  get; set; }
        // Documentos 
        [Required]
        [DisplayName("Documentos Legales")]
        public string DocumentosLegales { get; set; }
        [Required]
        [DisplayName("Certificaciones Legales")]
        public string CertificacionesLegales { get; set; }
        [Required]
        [DisplayName("Contrato Vigente")]
        public string ContratoVigente { get; set; }
        [Required]
        [DisplayName("Políticas de Devolución")]
        public string PoliticasDevolucion { get; set; }
        [Required]
        [DisplayName("Métodos de Transporte")]
        // Enum Transporte 
        public MetodosTransporteEnum MetodosTransporte { get; set; }
        // Enum Entrega 
        //public string ZonasEntrega { get; set; }
        [Required]
        [DisplayName("Costos Logísticos")]
        public decimal CostosLogisticos { get; set; }
        [Required]
        [DisplayName("Plazos de Entrega")]
        public int PlazosEntrega { get; set; }
        // Enum Normativas Cumplidas 
        //public string NormativasCumplidas { get; set; }
        [Required]
        [DisplayName("Última Fecha de Auditoria")]
        public DateTime FechaUltimaAuditoria { get; set; }
        [Required]
        [DisplayName("Requisitos Regulatorios")]
        public string RequisitosRegulatorios { get; set; }
        // Lista Historial Financiero y Riesgos 
        //public string HistorialPagos { get; set; }
        [Required]
        [DisplayName("Deuda Actual")]
        public decimal DeudaActual { get; set; }
        // Nivel de riesgo asociado con el proveedor basado en su historial financiero
        [Required]
        [DisplayName("Riesgo Proveedor")]
        public int RiesgoProveedor { get; set; }
        [Required]
        [DisplayName("Frecuencia de Compra")]
        public int FrecuenciaCompra { get; set; }
    }
}
