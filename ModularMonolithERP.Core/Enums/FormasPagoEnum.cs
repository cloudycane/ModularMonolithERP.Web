using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Enums
{
    public enum FormasPagoEnum
    {
        TransferenciaBancaria = 0,
        TarjetaCredito = 1,
        TarjetaDebito = 2,
        PayPal = 3,
        Cheque = 4,
        Efectivo = 5,
        GiroBancario = 6,
        Criptomonedas = 7,
    }

}
