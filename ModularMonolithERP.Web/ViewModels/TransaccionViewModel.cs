using ModularMonolithERP.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace ModularMonolithERP.Web.ViewModels
{
    public class TransaccionViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El campo '{0}' es requerido.")]
        [DisplayName("Tipo de Transacción")]
        [EnumDataType(typeof(TipoTransaccionEnum))]
        public TipoTransaccionEnum TipoTransaccion { get; set; }

        [DisplayName("Concepto")]
        [StringLength(100, ErrorMessage = "Los caracteres del campo '{0}' tiene un límite de hasta {1}.")]
        public string? Concepto { get; set; }

        [DisplayName("Tipo de Ingreso")]
        public TipoIngresoEnum? TipoIngreso { get; set; }

        [DisplayName("Tipo de Gasto")]
        public TipoGastoEnum? TipoGasto { get; set; }

        [Required(ErrorMessage = "El campo '{0}' es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "Este campo no acepta valores negativos.")]
        public decimal Importe { get; set; }

        [Required(ErrorMessage = "El campo '{0}' es requerido.")]
        [DisplayName("Fecha de Transacción")]
        public DateTime FechaTransaccion { get; set; }

        
    }
}
