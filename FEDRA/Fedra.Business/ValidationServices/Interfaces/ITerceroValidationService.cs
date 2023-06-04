using Fedra.Dto.Tercero;
using Fedra.Dto.Validation;

namespace Fedra.Business.ValidationServices.Interfaces
{
    public interface ITerceroValidationService
    {
        Task<ValidationResultDto> ValidateForCreate(CreateTerceroCriteriaDto criteria);
    }
}
