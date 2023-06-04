using Fedra.Dto.Tercero;
using Fedra.Dto.Validation;

namespace Fedra.Business.DomainServices.Interfaces
{
    public interface ITerceroDomainService
    {
        //Crear
        Task<(ValidationResultDto Validaciones, TerceroDto Tercero)> CreateTerceroAsync(CreateTerceroCriteriaDto criteria);

        //TODO:
        //Buscar  los 10 pruimeros terceros por nombre y numero de identificacion segun la pabara de busqueda.

        //Actualizar

        //Buscar Por tipo

        //Inactivar

        //Buscar por estado de activo o inactivo
        Task<List<TerceroDto>> GetTerceroPorEstadoAsync(long empresaId, int estado);
        //Reactivar        
    }
}
