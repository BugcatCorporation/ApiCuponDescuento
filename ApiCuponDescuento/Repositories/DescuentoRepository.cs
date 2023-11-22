using ApiCuponDescuento.DbContexts;
using ApiCuponDescuento.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCuponDescuento.Repositories
{
    public class DescuentoRepository : IDescuentoRepository
    {
        private readonly AppDbContext bgcontext;

        public DescuentoRepository(AppDbContext bgcontext)
        {
            this.bgcontext = bgcontext;
        }
        public async Task<Descuento> ActualizarDescuento(Descuento descuento)
        {
            bgcontext.Descuentos.Update(descuento);
            await bgcontext.SaveChangesAsync();
            return descuento;
        }

        public async Task<Descuento> AgregarDescuento(Descuento descuento)
        {
            bgcontext.Descuentos.Add(descuento);
            await bgcontext.SaveChangesAsync();
            return descuento;
        }

        public async Task<IEnumerable<Descuento>> BuscarDescuento()
        {
            return await bgcontext.Descuentos.ToListAsync();
        }

        public async Task<Descuento> BuscarDescuentoPorId(int id)
        {
            var descuento = await bgcontext.Descuentos.Where(c => c.DescuentoId == id).FirstOrDefaultAsync();
            return descuento; 

        }

        public async Task<bool> EliminarDescuento(int id)
        {
            var descuento = await bgcontext.Descuentos.FirstOrDefaultAsync(c => c.DescuentoId == id);
            if (descuento == null)
            {
                return false;
            }
            bgcontext.Descuentos.Remove(descuento);
            await bgcontext.SaveChangesAsync();
            return true;
        }
    }
}
