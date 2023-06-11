using Fedra.Data.Entities;

namespace Fedra.Data.Repositories.Interfaces
{
    public interface ITerceroRepository : IBaseRepository<Tercero>
    {
        IQueryable<Tercero> GetAll(bool includeTipoIdentificacion, bool includeDepartamento, bool includeMunicipio);
    }
}
