using Fedra.Business.ValidationServices.Interfaces;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;
using Fedra.Dto.Producto;
using Fedra.Dto.Validation;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Business.ValidationServices
{
    public class ProductoValidationService : IProductoValidationService
    {

        //inyectar la dependencia del repositorio, porque tenemos que validar que existe.

        private readonly IProductoRepository _productoRepository;

        public ProductoValidationService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public async Task<ValidationResultDto> ValidateForCreate(CreateProductoCriteriaDto criteria)
        {
            var result = new ValidationResultDto();

            //Valida que el producto a crear no exista, teniendo en cuenta el ID

            var validarExistencia = await ValidarExistenciaPorId(criteria.Nombre);

            if (!string.IsNullOrEmpty(validarExistencia.Mensaje))
            {
                result.Mensajes.Add(validarExistencia);
            }

            return result;
        }


        public async Task<(ValidationResultDto Validaciones, Producto ProductoEntity)> ValidateForUpdate(UpdateProductoCriteriaDto criteria)

        {
            var validationResult = new ValidationResultDto();

            //Valida que el producto con id exista
            var result = await ValidarExistenciaProductoById(criteria.Id);

            if (!string.IsNullOrEmpty(result.Validacion.Mensaje))
            {
                validationResult.Mensajes.Add(result.Validacion);
            }

            return (validationResult, result.ProductoEntity);
        }
          
        public async Task<(ValidationResultDto Validaciones, Producto ProductoEntity)> ValidateForUpdateEstado(UpdateEstadoProductoCriteriaDto criteria)
        {
            var validationResult = new ValidationResultDto();

            //Valida que el producto con el numero de id
            var result = await ValidarExistenciaProductoById(criteria.Id);

            if (!string.IsNullOrEmpty(result.Validacion.Mensaje))
            {
                validationResult.Mensajes.Add(result.Validacion);
            }

            return (validationResult, result.ProductoEntity);
        }


        private async Task<(ValidationConditionDto Validacion, Producto ProductoEntity)> ValidarExistenciaProductoById(long id)
        {
            var validacion = new ValidationConditionDto();
            
            var productoEntity = await _productoRepository.GetAll().FirstOrDefaultAsync(t => t.Id == id);
            
            if (productoEntity == null)
            {

                validacion.Mensaje = "El Producto No Existe";

                return (validacion, null);
            }

            return (validacion, productoEntity);
        }

        private async Task<ValidationConditionDto> ValidarExistenciaPorId(string productonombre)

        {
            var result = new ValidationConditionDto();

            var productoEntity = await _productoRepository.GetAll().FirstOrDefaultAsync(p => p.Nombre == productonombre);

            if (productoEntity != null)
            {

                result.Mensaje = "El Producto Existe";

                return result;
            }


            return result;
        }
    }
}

