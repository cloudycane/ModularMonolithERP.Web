using ModularMonolithERP.Core.Entidades;
using ModularMonolithERP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Application.UseCases.GetQueries
{
    public class ProductoSuministradorGetQuery
    {
        private readonly IProductoSuministradorRepositorio _productoSuministradorRepositorio;
        public ProductoSuministradorGetQuery(IProductoSuministradorRepositorio productoSuministradorRepositorio)
        {
            _productoSuministradorRepositorio = productoSuministradorRepositorio;
        }

        public async Task<IEnumerable<ProductoSuministradorModel>> ExecuteAsync()
        {
            var productosSuministrador = await _productoSuministradorRepositorio.ObtenerListadoProductoSuministrador();

            return productosSuministrador.Select(p => new ProductoSuministradorModel { Id = p.Id, NombreProducto = p.NombreProducto, DescripcionProducto = p.DescripcionProducto, CosteProducto = p.CosteProducto, CantidadProducto = p.CantidadProducto});
        }
    }
}
