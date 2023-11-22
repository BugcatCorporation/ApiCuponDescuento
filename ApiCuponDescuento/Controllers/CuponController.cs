using ApiCuponDescuento.Models;
using ApiCuponDescuento.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiCuponDescuento.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CuponController: ControllerBase
    {
        private readonly ICuponRepository cr;

        public CuponController(ICuponRepository cr)
        {
            this.cr = cr;
        }

        [HttpGet]
        [Route("BuscarCupon")]
        public async Task<ActionResult<IEnumerable<Cupon>>> buscarCupon()
        {
            return StatusCode(StatusCodes.Status200OK, await cr.BuscarCupon());
        }

        [HttpGet]
        [Route("BuscarCuponPorId/{id}")]
        public async Task<ActionResult<Cupon>> BuscarCuponPorId(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await cr.BuscarCuponPorId(id));
        }

        [HttpPost]
        [Route("AgregarCupon")]
        public async Task<ActionResult<Cupon>> AgregarCupon(Cupon cupon)
        {
            return StatusCode(StatusCodes.Status201Created, await cr.AgregarCupon(cupon));
        }

        [HttpPut]
        [Route("ActualizarCupon")]
        public async Task<ActionResult<Cupon>> ActualizarCupon(Cupon cupon)
        {
            return StatusCode(StatusCodes.Status200OK, await cr.ActualizarCupon(cupon));
        }

        [HttpDelete]
        [Route("EliminarCupon")]
        public async Task<ActionResult<bool>> EliminarCupon(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await cr.EliminarCupon(id));
        }

    }
}
