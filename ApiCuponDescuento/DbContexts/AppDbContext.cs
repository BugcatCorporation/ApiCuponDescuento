using ApiCuponDescuento.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCuponDescuento.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        public DbSet<Cupon> Cupones { get; set; }

        public DbSet<Descuento> Descuentos { get; set; }
    }
}
