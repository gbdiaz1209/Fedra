using Fedra.Dto.Producto;
using Fedra.Dto.Tercero;
using Fedra.Dto.Validation;

namespace Fedra.Business.DomainServices.Interfaces
{
    public interface IProductoDomainService
    {

        /// <summary>
        /// Crear Producto
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, ProductoDto Producto)> CreateProductoAsync(CreateProductoCriteriaDto criteria);

        /// <summary>
        /// Actualizar informacion general del producto
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, ProductoDto Producto)> UpdateProductoAsync(UpdateProductoCriteriaDto criteria);

        /// <summary>
        /// Activar o inactivar el producto usando el update
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, ProductoDto Producto)> UpdateEstadoProductoAsync(UpdateEstadoProductoCriteriaDto criteria);
        /// <summary>
        /// Buscar Productos por empresa y estado
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        Task<List<ProductoDto>> GetProductoPorEstadoAsync(long Id, string nombre);
       
    }
}
