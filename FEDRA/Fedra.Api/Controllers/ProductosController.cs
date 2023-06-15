using Fedra.Business.DomainServices.Interfaces;
using Fedra.Dto.Producto;
using Microsoft.AspNetCore.Mvc;

namespace Fedra.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private IProductoDomainService _productoDomainService; //estos son utilizados como parametros del constructor sin guion_bajo

        public ProductosController(IProductoDomainService productoDomainService) //constructor inyectado, necesito la interfaz
                                                                                 //y la implementacion de la misma forma
        {
            _productoDomainService = productoDomainService; //el producto que esta arriba recibe el del parametro
        }

        /// <summary>
        /// Lo primero que debemos hacer es un End point para Crear un Producto,
        /// Tiene el tipo de petición como es para crear
        /// utilizamos el HTTP POST en LLAVES, es decir es un decorador.
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        [HttpPost]
                                                                  //que necesitamos para crear un producto? El Criterio. 
                                                                  //Es decir, El DomainServices recibe el Criterio
                                                                  
        public async Task<ActionResult> CreateProductoAsync([FromBody] CreateProductoCriteriaDto criteria)
        {

            if (criteria == null) //Cada petición que se le haga a los EndPoint el debe dar una Respuesta
                                  //Las respuestas pueden ser Creado Domain, Respuestas de validación o un requerimiento invalido
            {
                return new BadRequestResult(); //primera validación
            }
                                                                                     //despues de inyectar la depencia la usamos.
            var result = await _productoDomainService.CreateProductoAsync(criteria); //para utilizar el DomainService en
                                                                                     // el controlador que debemos hacer?
                                                                                     // R. inyectarlo en el arriba en el constructor)

            if (result.Validaciones.Mensajes.Any())  //si hay algun mensaje en las validaciones o en los mensajes?
                                                      //si la respuesta es Si.. algo esta malo, devuelve Badrequest con todo esos mensajes
                                                      
            {
                return BadRequest(result.Validaciones.Mensajes); //que nos devuelve este metodo? R. unas validaciones
                                                                 //o un Producto Creado.
            }

            return new CreatedResult(String.Empty, result.Producto); //pero si no hay mensajes, devuelveme al producto Creado
        }                                                               //createdResult recibe varios parametros por ende usamos String.Empty

        /// <summary>
        /// Buscar
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        
        [HttpGet("GetByEstado")]
        public async Task<ActionResult> GetByEstadoAsync(long Id, string nombre)
        {
            var productos = await _productoDomainService.GetProductoPorEstadoAsync(Id, nombre); //petición Asincrona

            var result = new //creamos un objeto de resultado
            {
                Productos = productos //estos son los productos que fueron buscados con el metodo away y get
            };

            return new ObjectResult(result); //devuelvo el objeto en este caso los productos buscados por Id y nombre
        }

        /// <summary>
        /// Se utiliza put cuando es actualizar
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] UpdateProductoCriteriaDto criteria)
        {

            if (criteria == null)
            {
                return new BadRequestResult();
            }

            var result = await _productoDomainService.UpdateProductoAsync(criteria);

            if (result.Validaciones.Mensajes.Any())
            {
                return BadRequest(result.Validaciones.Mensajes);
            }

            return new OkObjectResult(result.Producto);
        }

        /// <summary>
        /// Se utiliza put cuando es actualizar
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        [HttpPut("UpdateEstado")]
        public async Task<ActionResult> UpdateEstadoAsync([FromBody] UpdateEstadoProductoCriteriaDto criteria)
        {


            if (criteria == null)
            {
                return new BadRequestResult();
            }

            var result = await _productoDomainService.UpdateEstadoProductoAsync(criteria);

            if (result.Validaciones.Mensajes.Any())
            {
                return BadRequest(result.Validaciones.Mensajes);
            }

            return new OkObjectResult(result.Producto);
        }



    }
}
