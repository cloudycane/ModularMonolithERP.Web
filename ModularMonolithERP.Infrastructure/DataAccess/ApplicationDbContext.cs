using Microsoft.EntityFrameworkCore;
using ModularMonolithERP.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Infrastructure.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransaccionModel> Transacciones { get; set; }
        public DbSet<SuministradorModel> Suministradores { get; set; }
        public DbSet<ProductoSuministradorModel> ProductosSuministradores { get; set; }
    }
}
