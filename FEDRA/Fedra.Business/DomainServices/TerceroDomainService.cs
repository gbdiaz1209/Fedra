using Fedra.Business.DomainServices.Interfaces;
using Fedra.Business.Extensions;
using Fedra.Data.Repositories.Interfaces;
using Fedra.Dto.Tercero;

namespace Fedra.Business.DomainServices
{
    public class TerceroDomainService : ITerceroDomainService
    {
        private readonly ITerceroRepository _terceroRepository;

        public TerceroDomainService(ITerceroRepository terceroRepository)
        {
            _terceroRepository = terceroRepository;
        }

        public async Task<TerceroDto> CreateTerceroAsync(CreateTerceroCriteriaDto criteria)
        {
            // TODO: crear el servicio de validacion  / validarlo

            // Si es valido, usar el repositorio de tercero para crearlo

            //Mapear criteria DTO a la entidad
            var terceroEntity = criteria.ConvertDtoToEntity();

            // usar el tercero repositorio para guardar la fila en la tabla.
            _terceroRepository.Add(terceroEntity);
            await _terceroRepository.SaveChangesAsync();

            //mapear/convertir la entidad que me devuelve EF al DTO que necesito mandarle al la capa superior
            var result = terceroEntity.ConvertEntityToDto();
            
            //retornar el DTO
            return result;
        }
    }
}
