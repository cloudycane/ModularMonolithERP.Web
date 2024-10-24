using ModularMonolithERP.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Interfaces
{
    public interface IProductoSuministradorRepositorio
    {
        Task CrearAsync(ProductoSuministradorModel producto);
        Task<IEnumerable<ProductoSuministradorModel>> ObtenerListadoProductoSuministrador();
    }
}
