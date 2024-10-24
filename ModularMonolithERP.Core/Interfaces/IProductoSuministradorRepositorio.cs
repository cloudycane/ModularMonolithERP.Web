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
        Task<ProductoSuministradorModel> GetProductoAsync(int id);
        Task<IEnumerable<ProductoSuministradorModel>> ObtenerListadoProductoSuministrador();
        Task<ProductoSuministradorModel> ObtenerProductoSuministradorPorIdAsync(int id);
    }
}
