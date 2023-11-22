using ApiCuponDescuento.Models;

namespace ApiCuponDescuento.Repositories
{
    public interface ICuponRepository
    {
        public Task<IEnumerable<Cupon>> BuscarCupon();
        public Task<Cupon> BuscarCuponPorId(int id);
        public Task<Cupon> AgregarCupon(Cupon cupon);
        public Task<Cupon> ActualizarCupon(Cupon cupon);
        public Task<bool> EliminarCupon(int id);


    }
}
