using Fedra.Business.DomainServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Fedra.Dto.Comprobante;

namespace Fedra.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobantesController : ControllerBase
    {
        private IComprobanteDomainService _comprobanteDomainService; //estos son utilizados como parametros del constructor sin guion_bajo

        public ComprobantesController(IComprobanteDomainService comprobanteDomainService) //constructor inyectado, necesito la interfaz
                                                                                         //y la implementacion de la misma forma
        {
            _comprobanteDomainService = comprobanteDomainService; //el comprobante que esta arriba recibe el del parametro
        }

       
        /// <summary>
        /// Buscar
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>

        /// <summary>
        /// Se utiliza put cuando es actualizar
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        [HttpGet("GetByID")]
        public async Task<ActionResult> GetComprobanteByIdAsync(long id)
        {
            var comprobantes = await _comprobanteDomainService.GetComprobanteByIdAsync(id); //petición Asincrona

            var result = new //creamos un objeto de resultado
            {
                Comprobantes = comprobantes //estos son los comprobantes que fueron buscados con el metodo away y get
            };

            return new ObjectResult(result);
        }
        /// <summary>
        /// Se utiliza put cuando es actualizar
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] UpdateComprobanteCriteriaDto criteria)
        {

            if (criteria == null)
            {
                return new BadRequestResult();
            }

            var result = await _comprobanteDomainService.UpdateComprobanteAsync(criteria);

            if (result.Validaciones.Mensajes.Any())
            {
                return BadRequest(result.Validaciones.Mensajes);
            }

            return new OkObjectResult(result.Comprobante);
        }
  
    }
}
