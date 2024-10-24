using Microsoft.AspNetCore.Mvc.Rendering;
using ModularMonolithERP.Core.Entidades;

namespace ModularMonolithERP.Web.ViewModels
{
    public class ProductoSuministradorViewModel
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal CosteProducto { get; set; }
        public int CantidadProducto { get; set; }
        public int SuministradorId { get; set; }
        public SelectList Suministrador { get; set; }

    }
}
