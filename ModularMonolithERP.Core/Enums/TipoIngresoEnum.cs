using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Enums
{
    public enum TipoIngresoEnum
    {
        [Display(Name = "Ingreso de Explotación")]
        IngresoDeExplotacion = 0,
        [Display(Name = "Ventas")]
        Ventas = 1,
        [Display(Name = "Subvenciones a la Explotación")]
        SubvencionesALaExplotacion = 2,
        [Display(Name = "Arrendamientos")]
        Arrendamientos = 3,
        [Display(Name = "Comisiones")]
        Comisiones = 4,
        [Display(Name = "Ingresos Excepcionales")]
        IngresosExcepcionales = 5,
        [Display(Name = "Venta de Inmuebles")]
        VentaInmuebles = 6,
        [Display(Name = "Ingresos Financieros")]
        IngresosFinancieros = 7
    }
}
