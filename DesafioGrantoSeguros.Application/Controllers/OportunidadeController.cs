using DesafioGrantoSeguros.Domain.Entities;
using DesafioGrantoSeguros.Domain.Interfaces.Services;
using DesafioGrantoSeguros.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioGrantoSeguros.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OportunidadeController : ControllerBase
    {
        private readonly IOportunidadeService _oportunidadeService;

        public OportunidadeController(IOportunidadeService oportunidadeService)
        {
            _oportunidadeService = oportunidadeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _oportunidadeService.GetOportunidadesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _oportunidadeService.GetOportunidadeAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Oportunidade oportunidade)
        {
            var oportunidadeInserida = await _oportunidadeService.InsertOportunidadeAsync(oportunidade);
            return CreatedAtAction(nameof(Get), new { id = oportunidade.Id }, oportunidadeInserida);
        }
    }
}
