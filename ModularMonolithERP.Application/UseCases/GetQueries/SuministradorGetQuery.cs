using ModularMonolithERP.Core.Entidades;
using ModularMonolithERP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Application.UseCases.GetQueries
{
    public class SuministradorGetQuery
    {
        private readonly ISuministradorRepositorio _suministradorRepositorio;
        public SuministradorGetQuery(ISuministradorRepositorio suministradorRepositorio)
        {
            _suministradorRepositorio = suministradorRepositorio;
        }

        public async Task<IEnumerable<SuministradorModel>> ExecuteAsync()
        {
            var suministrador = await _suministradorRepositorio.ObtenerListadoSuministradorAsync();

            return suministrador.Select(s => new SuministradorModel { Id = s.Id, CategoriaProveedor = s.CategoriaProveedor, CondicionesPagoEnum = s.CondicionesPagoEnum, Direccion = s.Direccion, Descripcion = s.Direccion, FormasPago = s.FormasPago, Email = s.Email, MetodosTransporte = s.MetodosTransporte, MonedaPreferida = s.MonedaPreferida, Nombre = s.Nombre, PaisOrigen = s.PaisOrigen, ProductoSuministrador = s.ProductoSuministrador, TelefonoContacto = s.TelefonoContacto, TipoProveedor = s.TipoProveedor});
        }
        
    }
}
