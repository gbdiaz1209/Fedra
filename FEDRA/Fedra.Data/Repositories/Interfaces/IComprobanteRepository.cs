using Fedra.Data.Entities;

namespace Fedra.Data.Repositories.Interfaces
{
    public interface IComprobanteRepository : BaseRepository<Comprobante>
    {
        IQueryable<Comprobante> GetAll(bool includeIngreso, bool includeEgreso);


    }
}
