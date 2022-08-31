using DesafioGrantoSeguros.Domain.Entities;
using DesafioGrantoSeguros.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesafioGrantoSeguros.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorService _vendedorService;

        public VendedorController(IVendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        // GET: api/<VendedorController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _vendedorService.GetVendedoresAsync());
        }

        // GET api/<VendedorController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _vendedorService.GetVendedorAsync(id));
        }

        // POST api/<VendedorController>
        [HttpPost]
        public async Task<IActionResult> Post(Vendedor vendedor)
        {
            var vendedorInserido = await _vendedorService.InsertVendedorAsync(vendedor);
            return CreatedAtAction(nameof(Get), new { id = vendedor.Id }, vendedorInserido);
        }

        // PUT api/<VendedorController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Vendedor vendedor)
        {
            var vendedorAtualizado = await _vendedorService.UpdateVendedorAsync(vendedor);

            if (vendedorAtualizado == null)
                return NotFound();

            return Ok(vendedorAtualizado);
        }

        // DELETE api/<VendedorController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _vendedorService.DeleteVendedorAsync(id);
            return NoContent();
        }
    }
}
