
using Fedra.Dto.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Task<(ValidationResultDto Validaciones, ProductoDto Producto)> UpdateEstadoProductoAsync(UpdateEstadoCriteriaDto criteria);

        /// <summary>
        /// Buscar Productos por empresa y estado
        /// </summary>
        /// <param name="empresaId"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        Task<List<ProductoDto>> GetProductoPorEstadoAsync(long empresaId, int estado);

    }
}
