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
    public class ProductoSuministradorRepositorio : IProductoSuministradorRepositorio
    {
        private readonly ApplicationDbContext _context;
        public ProductoSuministradorRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<ProductoSuministradorModel>> ObtenerListadoProductoSuministrador()
        {
            return await _context.ProductosSuministradores.ToListAsync();
        }
    
    }
}
