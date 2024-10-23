using ModularMonolithERP.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Entidades
{
    public class SuministradorModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public CategoriaProveedorEnum CategoriaProveedor { get; set; }
        public CondicionesPagoEnum CondicionesPagoEnum { get; set; }
        public FormasPagoEnum FormasPago { get; set; }
        public MetodosTransporteEnum MetodosTransporte { get; set; }
        public string Email { get; set; }
        public string TelefonoContacto { get; set; }
        public MonedaPreferidaEnum MonedaPreferida { get; set; }
        public TipoProveedorEnum TipoProveedor { get; set; }
        public PaisOrigenEnum PaisOrigen { get; set; }
        // nav property
        public int ProductoSuministradorId { get; set; }
        public ProductoSuministradorModel ProductoSuministrador { get; set; }
    }
}
