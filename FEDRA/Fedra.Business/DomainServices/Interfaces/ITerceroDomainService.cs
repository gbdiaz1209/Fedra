using Fedra.Dto.Tercero;
using Fedra.Dto.Validation;

namespace Fedra.Business.DomainServices.Interfaces
{
    public interface ITerceroDomainService
    {
        /// <summary>
        /// Crear Tercero
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, TerceroDto Tercero)> CreateTerceroAsync(CreateTerceroCriteriaDto criteria);

        /// <summary>
        /// Actualizar informacion general del tercero
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, TerceroDto Tercero)> UpdateTerceroAsync(UpdateTerceroCriteriaDto criteria);

        /// <summary>
        /// Activar o inactivar el tercero usando el update
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, TerceroDto Tercero)> UpdateEstadoTerceroAsync(UpdateEstadoCriteriaDto criteria);
       
        /// <summary>
        /// Buscar Terceros por empresa y estado
        /// </summary>
        /// <param name="empresaId"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        Task<List<TerceroDto>> GetTerceroPorEstadoAsync(long empresaId, int estado);
              
    }
}
