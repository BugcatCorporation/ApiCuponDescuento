using ApiCuponDescuento.Models;

namespace ApiCuponDescuento.Repositories
{
    public interface IDescuentoRepository
    {
        public Task<IEnumerable<Descuento>> BuscarDescuento();
        public Task<Descuento> BuscarDescuentoPorId(int id);
        public Task<Descuento> AgregarDescuento(Descuento descuento);
        public Task<Descuento> ActualizarDescuento(Descuento descuento);
        public Task<bool> EliminarDescuento(int id);
    }
}
