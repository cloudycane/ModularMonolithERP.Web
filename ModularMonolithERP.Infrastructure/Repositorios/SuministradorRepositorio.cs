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
    public class SuministradorRepositorio : ISuministradorRepositorio
    {
        private readonly ApplicationDbContext _context; 

        public SuministradorRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SuministradorModel>> ObtenerListadoSuministradorAsync()
        {
            return await _context.Suministradores.ToListAsync();
        }

        public async Task CrearSuministrador(SuministradorModel suministrador)
        {
            await _context.AddAsync(suministrador);
            await _context.SaveChangesAsync();  
        }
    }
}
