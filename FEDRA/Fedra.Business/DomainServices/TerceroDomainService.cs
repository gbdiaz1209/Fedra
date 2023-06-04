using Fedra.Business.Constants;
using Fedra.Business.DomainServices.Interfaces;
using Fedra.Business.Extensions;
using Fedra.Business.ValidationServices.Interfaces;
using Fedra.Data.Repositories.Interfaces;
using Fedra.Dto.Tercero;
using Fedra.Dto.Validation;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Business.DomainServices
{
    public class TerceroDomainService : ITerceroDomainService
    {
        private readonly ITerceroRepository _terceroRepository;
        private readonly ITerceroValidationService _terceroValidationService;

        public TerceroDomainService(ITerceroRepository terceroRepository, ITerceroValidationService terceroValidationService)
        {
            _terceroRepository = terceroRepository;
            _terceroValidationService = terceroValidationService;
        }

        public async Task<(ValidationResultDto Validaciones, TerceroDto Tercero)> CreateTerceroAsync(CreateTerceroCriteriaDto criteria)
        {
            //servicio de validacion  / validarlo
            var validationResult = await _terceroValidationService.ValidateForCreate(criteria);

            if (validationResult.Mensajes.Any())
            {
                return (validationResult, null);
            }

            // Si es valido, usar el repositorio de tercero para crearlo

            //Mapear criteria DTO a la entidad
            var terceroEntity = criteria.ConvertDtoToEntity();

            // usar el tercero repositorio para guardar la fila en la tabla.
            _terceroRepository.Add(terceroEntity);
            await _terceroRepository.SaveChangesAsync();

            //mapear/convertir la entidad que me devuelve EF al DTO que necesito mandarle al la capa superior
            var dto = terceroEntity.ConvertEntityToDto();
            
            //retornar el DTO
            return (validationResult, dto);
        }

        public async Task<List<TerceroDto>> GetTerceroPorEstadoAsync(long empresaId, int estado)
        {
            var tercerosBuscados = await _terceroRepository
                                                           .GetAll()
                                                           .Where(t => t.EmpresaId == empresaId &&
                                                                    t.Estado == estado)
                                                           .ToListAsync();

            //seleccionar tercero por tercero y convertirlo a dto
            var tercerosComoDto = tercerosBuscados.Select(tb => tb.ConvertEntityToDto()).ToList();

            return tercerosComoDto;
        }
    }
}
