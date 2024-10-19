using Microsoft.EntityFrameworkCore;
using ModularMonolithERP.Core.Entidades;
using ModularMonolithERP.Core.Interfaces;
using ModularMonolithERP.Infrastructure.DataAccess;

namespace ModularMonolithERP.Infrastructure.Repositorios
{
    /// <summary>
    /// Recuerda que los metodos que retornan algo (por ejemplo obtener listado) requieren "return await" 
    /// Y los que no como los Crear, Actualizar, y Eliminar sólo requieren await 
    /// </summary>
    
    public class TransaccionRepositorio : ITransaccionRepositorio
    {
        private readonly ApplicationDbContext _context; 
        public TransaccionRepositorio(ApplicationDbContext context) 
        {
            _context = context;
        }

        // Obtener listado de Transaccion

        public async Task<IEnumerable<TransaccionModel>> ObtenerListadoTransaccionAsync()
        {
            return await _context.Transacciones.ToListAsync();
            // Utilizamos Include() si tenemos una foreign key...
        }

        // Obtener listado de Transaccion por Id

        public async Task<TransaccionModel> ObtenerTransaccionPorIdAsync(int id)
        {
            return await _context.Set<TransaccionModel>().FindAsync(id);
        }

        // Buscar por palabra 

        // Crear Transaccion 
        public async Task CreateAsync(TransaccionModel transaccion)
        {
            await _context.Transacciones.AddAsync(transaccion);
            await _context.SaveChangesAsync();
        }
        // Editar o Actualizar Transaccion 

        // Eliminar Transaccion 


    }
}
