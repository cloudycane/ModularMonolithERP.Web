using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Entidades
{
    public class ProductoSuministradorModel
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal CosteProducto { get; set; }
        public int CantidadProducto { get; set; }
    }
}
