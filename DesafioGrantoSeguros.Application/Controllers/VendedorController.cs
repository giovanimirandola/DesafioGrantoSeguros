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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _vendedorService.GetVendedoresAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _vendedorService.GetVendedorAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Vendedor vendedor)
        {
            var vendedorInserido = await _vendedorService.InsertVendedorAsync(vendedor);
            return CreatedAtAction(nameof(Get), new { id = vendedor.Id }, vendedorInserido);
        }

    }
}
