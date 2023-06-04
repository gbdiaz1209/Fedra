using Fedra.Dto.Tercero;

namespace Fedra.Business.DomainServices.Interfaces
{
    public interface ITerceroDomainService
    {
        //Crear
        Task<TerceroDto> CreateTerceroAsync(CreateTerceroCriteriaDto criteria);

        //TODO:
        //Buscar

        //Actualizar

        //Buscar Por tipo

        //Inactivar

        //Buscar por estado de activo o inactivo

        //Reactivar        
    }
}
