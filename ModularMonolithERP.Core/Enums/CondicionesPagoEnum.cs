using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Enums
{
    public enum CondicionesPagoEnum
    {
        PagoAdelantado,
        PagoContraEntrega,
        Neto30Dias,   // Pago a 30 días
        Neto60Dias,   // Pago a 60 días
        Neto90Dias,   // Pago a 90 días
        PagoMensual,
        PagoTrimestral,
        PagoAnual
    }

}
