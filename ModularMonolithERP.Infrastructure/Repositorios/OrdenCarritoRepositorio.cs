using Microsoft.EntityFrameworkCore;
using ModularMonolithERP.Core.Entidades;
using ModularMonolithERP.Core.Interfaces;
using ModularMonolithERP.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Infrastructure.Repositorios
{
    public class OrdenCarritoRepositorio : IOrdenCarritoRepositorio
    {
        private readonly ApplicationDbContext _context;

        public OrdenCarritoRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrdenCarritoModel>> ObtenerListadoOrdenCarritoAsync()
        {
            return await _context.OrdenesCarritos.Include(p => p.ProductoSuministrador).ToListAsync();
        }

    }
}
