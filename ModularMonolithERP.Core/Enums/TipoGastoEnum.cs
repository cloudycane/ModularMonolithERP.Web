using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Enums
{
    public enum TipoGastoEnum
    {
        [Display(Name = "Gastos de Explotación")]
        GastosDeExplotacion = 0,
        [Display(Name = "Gastos Excepcionales")]
        GastosExcepcionales = 1,
        [Display(Name = "Gastos Financieros")]
        GastosFinancieros = 2
    }
}
