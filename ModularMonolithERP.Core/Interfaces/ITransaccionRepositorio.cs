using ModularMonolithERP.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Interfaces
{
    public interface ITransaccionRepositorio
    {
        Task CreateAsync(TransaccionModel transaccion);
        Task<IEnumerable<TransaccionModel>> ObtenerListadoTransaccionAsync();
        Task<TransaccionModel> ObtenerTransaccionPorIdAsync(int id);
    }
}
