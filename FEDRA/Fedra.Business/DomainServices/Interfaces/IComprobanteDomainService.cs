using Fedra.Dto.Comprobante;
using Fedra.Dto.Validation;

namespace Fedra.Business.DomainServices.Interfaces
{
    public interface IComprobanteDomainService
    {
        /// <summary>
        /// Crear Comprobante
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, ComprobanteDto Comprobante)> CreateComprobanteAsync(CreateComprobanteCriteriaDto criteria);

        /// <summary>
        /// Actualizar informacion general del comprobante
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        Task<(ValidationResultDto Validaciones, ComprobanteDto Comprobante)> UpdateComprobanteAsync(UpdateComprobanteCriteriaDto criteria);

        /// <summary>
        /// Activar o inactivar el comprobante usando el update
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>


        /// <summary>
        /// Buscar Comprobantes por empresa y estado
        /// </summary>
        /// <param name="empresaId"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        Task<List<ComprobanteDto>> GetComprobantePorEstadoAsync(long empresaId, int estado);
    }
}
