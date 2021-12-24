using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIYapsi.Entities;

namespace WebAPIYapsi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Movimientos> Movimientos { get; set; }
        public DbSet<TipoMovimientos> TipoMovimientos { get; set; }


    }
}
