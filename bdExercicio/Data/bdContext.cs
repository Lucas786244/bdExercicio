using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bdExercicio.Models;

namespace bdExercicio.Data
{
    public class bdContext : DbContext
    {
        public bdContext (DbContextOptions<bdContext> options)
            : base(options)
        {
        }

        public DbSet<bdExercicio.Models.CadClientes> CadClientes { get; set; } = default!;

        public DbSet<bdExercicio.Models.CadMaquinas> CadMaquinas { get; set; } = default!;

        public DbSet<bdExercicio.Models.Inventario> Inventario { get; set; } = default!;
    }
}
