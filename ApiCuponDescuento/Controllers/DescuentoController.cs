using ApiCuponDescuento.Models;
using ApiCuponDescuento.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiCuponDescuento.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DescuentoController:ControllerBase
    {
        private readonly IDescuentoRepository dr;
        
        public DescuentoController(IDescuentoRepository dr)
        {
            this.dr = dr;   
        }

        [HttpGet]
        [Route("ListaDescuentos")]
        public async Task<ActionResult<IEnumerable<Descuento>>> BuscarDescuentos()
        {
            return StatusCode(StatusCodes.Status200OK, await dr.BuscarDescuento());

        }

        [HttpGet]
        [Route("BuscarDescuentoPorId/{id}")]
        public async Task<ActionResult<Descuento>> BuscarDescuentoPorId(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await dr.BuscarDescuentoPorId(id));
        }

        [HttpPost]
        [Route("AgregarDescuento")]
        public async Task<ActionResult<Descuento>> AgregarDescuento(Descuento descuento)
        {
            return StatusCode(StatusCodes.Status201Created, await dr.AgregarDescuento(descuento));
        }

        [HttpPut]
        [Route("ActualizarDescuento")]
        public async Task<ActionResult<Descuento>> ActualizarDescuento(Descuento descuento)
        {
            return StatusCode(StatusCodes.Status200OK, await dr.ActualizarDescuento(descuento));
        }

        [HttpDelete]
        [Route("EliminarDescuento")]
        public async Task<ActionResult<bool>> EliminarDescuento(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await dr.EliminarDescuento(id));
        }
    }
}
