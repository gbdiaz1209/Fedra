using Fedra.Data.Entities;
using Fedra.Dto.Tercero;
using Fedra.Dto.Validation;

namespace Fedra.Business.ValidationServices.Interfaces
{
    public interface ITerceroValidationService
    {
        /// <summary>
        /// Solo validamos el tercero por el numero de identificacion
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<ValidationResultDto> ValidateForCreate(CreateTerceroCriteriaDto criteria);

        /// <summary>
        /// Validamos la existencia por Id
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, Tercero TerceroEntity)> ValidateForUpdate(UpdateTerceroCriteriaDto criteria);

        /// <summary>
        /// Validar Existencia edl tercero para cambiar el estado
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, Tercero TerceroEntity)> ValidateForUpdateEstado(UpdateEstadoCriteriaDto criteria);
    }
}
