using Fedra.Data.Entities;
using Fedra.Dto.Producto;
using Fedra.Dto.Validation;

namespace Fedra.Business.ValidationServices.Interfaces
{
    public interface IProductoValidationService
    {
        /// <summary>
        /// Solo validamos el producto por el numero de identificacion
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<ValidationResultDto> ValidateForCreate(CreateProductoCriteriaDto criteria);

        /// <summary>
        /// Validamos la existencia del producto por Id
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, Producto ProductoEntity)> ValidateForUpdate(UpdateProductoCriteriaDto criteria);

        /// <summary>
        /// Validar Existencia edl tercero para cambiar el estado
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, Producto ProductoEntity)> ValidateForUpdateEstado(UpdateEstadoProductoCriteriaDto criteria);
    }
}

 