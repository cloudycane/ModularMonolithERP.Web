using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Enums
{
    public enum CondicionesPagoEnum
    {
        PagoAdelantado = 0,
        PagoContraEntrega = 1,
        Neto30Dias = 2,   // Pago a 30 días
        Neto60Dias = 3,   // Pago a 60 días
        Neto90Dias = 4,   // Pago a 90 días
        PagoMensual = 5,
        PagoTrimestral = 6,
        PagoAnual = 7,
    }

}
