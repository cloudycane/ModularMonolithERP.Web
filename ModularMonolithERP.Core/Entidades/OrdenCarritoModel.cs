using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Entidades
{
    public class OrdenCarritoModel
    {
        public int Id { get; set; }
        public int ProductoSuministradorId { get; set; }
        public ProductoSuministradorModel ProductoSuministrador { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal TotalCoste {  get; set; }
    }
}
