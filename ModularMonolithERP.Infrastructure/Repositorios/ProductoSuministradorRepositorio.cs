﻿using Microsoft.EntityFrameworkCore;
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
            return await _context.ProductosSuministradores.Include(s => s.Suministrador).ToListAsync();
        }

        public async Task<ProductoSuministradorModel> ObtenerProductoSuministradorPorIdAsync(int id)
        {
            return await _context.Set<ProductoSuministradorModel>().FindAsync(id);
        }
        
        
        public async Task CrearAsync(ProductoSuministradorModel producto)
        {
            await _context.AddAsync(producto);
            await _context.SaveChangesAsync();
        }

        public async Task<ProductoSuministradorModel> GetProductoAsync(int id)
        {
            return await _context.ProductosSuministradores.SingleOrDefaultAsync(p => p.Id == id);
        }
    
    }
}
