using ModularMonolithERP.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Entidades
{
    public class TransaccionModel
    {
        public Guid Id { get; set; }
        public TipoTransaccionEnum TipoTransaccion { get; set; }
        public TipoIngresoEnum? TipoIngreso { get; set; }
        public TipoGastoEnum? TipoGasto { get; set; }
        public string? Concepto { get; set; }
        public decimal Importe { get; set; }
        public DateTime FechaTransaccion { get; set; }
       
    }
}
