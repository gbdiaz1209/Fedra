using Fedra.Business.DomainServices.Interfaces;
using Fedra.Dto.Tercero;
using Microsoft.AspNetCore.Mvc;

namespace Fedra.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TercerosController : ControllerBase
    {
        private ITerceroDomainService _terceroDomainService;

        public TercerosController(ITerceroDomainService terceroDomainService)
        {
            _terceroDomainService = terceroDomainService;
        }

        /// <summary>
        /// End point para crear un Tercero, Tiene el tipo de peticion como es para crear
        /// utilizamos el HTTP POST en LLAVES, es decir es un decorador.
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CreateTerceroCriteriaDto criteria)
        {

            if (criteria == null)
            {
                return new BadRequestResult();
            }

            var result = await _terceroDomainService.CreateTerceroAsync(criteria);

            if (result.Validaciones.Mensajes.Any())
            {
                return BadRequest(result.Validaciones.Mensajes);
            }

            return new CreatedResult(String.Empty, result.Tercero);
        }

        
        [HttpGet("GetByEstado")]
        public async Task<ActionResult> GetByEstadoAsync(long empresaId, int estado)
        {
            var terceros = await _terceroDomainService.GetTerceroPorEstadoAsync(empresaId, estado);

            var result = new
            {
                Terceros = terceros
            };

            return new ObjectResult(result);
        }

        /// <summary>
        /// Se utiliza put cuando es actualizar
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] UpdateTerceroCriteriaDto criteria)
        {

            if (criteria == null)
            {
                return new BadRequestResult();
            }

            var result = await _terceroDomainService.UpdateTerceroAsync(criteria);

            if (result.Validaciones.Mensajes.Any())
            {
                return BadRequest(result.Validaciones.Mensajes);
            }

            return new OkObjectResult(result.Tercero);
        }

        /// <summary>
        /// Se utiliza put cuando es actualizar
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        [HttpPut("UpdateEstado")]
        public async Task<ActionResult> UpdateEstadoAsync([FromBody] UpdateEstadoCriteriaDto criteria)
        {

            if (criteria == null)
            {
                return new BadRequestResult();
            }

            var result = await _terceroDomainService.UpdateEstadoTerceroAsync(criteria);

            if (result.Validaciones.Mensajes.Any())
            {
                return BadRequest(result.Validaciones.Mensajes);
            }

            return new OkObjectResult(result.Tercero);
        }
    }
}
