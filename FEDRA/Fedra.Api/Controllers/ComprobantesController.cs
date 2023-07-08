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
              
        [HttpPost]
        public async Task<ActionResult> CreateProductoAsync([FromBody] CreateComprobanteCriteriaDto criteria)
        {

            if (criteria == null) //Cada petición que se le haga a los EndPoint el debe dar una Respuesta
                                  //Las respuestas pueden ser Creado Domain, Respuestas de validación o un requerimiento invalido
            {
                return new BadRequestResult(); //primera validación
            }
            //despues de inyectar la depencia la usamos.
            var result = await _comprobanteDomainService.CreateComprobanteAsync(criteria); //para utilizar el DomainService en
                                                                                     // el controlador que debemos hacer?
                                                                                     // R. inyectarlo en el arriba en el constructor)
                                                                                     
            return new CreatedResult(String.Empty, result); //pero si no hay mensajes, devuelveme al producto Creado
        }

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
               
        [HttpPut("UpdateEstado")]
        public async Task<ActionResult> UpdateEstadoAsync([FromBody] UpdateComprobanteEstadoCriteriaDto criteria)
        {

            if (criteria == null)
            {
                return new BadRequestResult();
            }

            var result = await _comprobanteDomainService.UpdateComprobanteEstadoAsync(criteria);

            if (result.Validaciones.Mensajes.Any())
            {
                return BadRequest(result.Validaciones.Mensajes);
            }

            return new OkObjectResult(result.Comprobante);
        }

    }
}
