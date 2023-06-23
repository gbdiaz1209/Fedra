using Fedra.Dto.Comprobante;
using Fedra.Dto.Validation;

namespace Fedra.Business.DomainServices.Interfaces
{
    public interface IComprobanteDomainService
    {
        Task<List<ComprobanteDto>> GetComprobanteByIdAsync(long id);
        Task<(ValidationResultDto Validaciones, ComprobanteDto Comprobante)> UpdateComprobanteAsync(UpdateComprobanteCriteriaDto criteria);
        Task<ComprobanteDto> CreateComprobanteAsync(CreateComprobanteCriteriaDto criteria);
    }
}
