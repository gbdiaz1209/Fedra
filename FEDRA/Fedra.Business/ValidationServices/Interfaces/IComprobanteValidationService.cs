using Fedra.Data.Entities;
using Fedra.Dto.Comprobante;
using Fedra.Dto.Validation;

namespace Fedra.Business.ValidationServices.Interfaces
{
    public interface IComprobanteValidationService
    {
        Task<(ValidationResultDto Validaciones, Comprobante ComprobanteEntity)> ValidateForUpdate(UpdateComprobanteCriteriaDto criteria);
    }
}
