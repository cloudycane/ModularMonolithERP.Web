using Microsoft.AspNetCore.Mvc.Rendering;
using ModularMonolithERP.Core.Entidades;
using ModularMonolithERP.Core.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModularMonolithERP.Web.ViewModels
{
    public class SuministradorViewModel
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

        // Navigation Property
        public int? ProductoSuministradorId { get; set; }

        // DropDownList for ProductoSuministrador
        public SelectList ProductoSuministradorSelectListItem { get; set; } = new SelectList(Enumerable.Empty<SelectListItem>());
    }

}
