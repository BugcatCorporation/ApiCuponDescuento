using ApiCuponDescuento.DbContexts;
using ApiCuponDescuento.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCuponDescuento.Repositories
{
    public class CuponRepository : ICuponRepository
    {
        private readonly AppDbContext bgcontext;

        public CuponRepository(AppDbContext bgcontext)
        {
            this.bgcontext = bgcontext;
        }
        public async Task<Cupon> ActualizarCupon(Cupon cupon)
        {
            bgcontext.Cupones.Update(cupon);
            await bgcontext.SaveChangesAsync();
            return cupon;
        }

        public async Task<Cupon> AgregarCupon(Cupon cupon)
        {
            bgcontext.Cupones.Add(cupon);
            await bgcontext.SaveChangesAsync();
            return cupon;
        }

        public async Task<IEnumerable<Cupon>> BuscarCupon()
        {
            return await bgcontext.Cupones.Include(c => c.Descuento).ToListAsync();
        }

        public async Task<Cupon> BuscarCuponPorId(int id)
        {
            var cupon = await bgcontext.Cupones.Where(c => c.CuponId == id).Include(c => c.Descuento).FirstOrDefaultAsync();
            return cupon;
        }

        public async Task<bool> EliminarCupon(int id)
        {
            var cupon = await bgcontext.Cupones.FirstOrDefaultAsync(c => c.CuponId == id);
            if (cupon == null )
            {
                return false;
            }
            bgcontext.Cupones.Remove(cupon);
            await bgcontext.SaveChangesAsync();
            return true;
        }
    }
}
