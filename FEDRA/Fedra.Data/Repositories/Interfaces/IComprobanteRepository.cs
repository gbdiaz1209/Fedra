using Fedra.Data.Entities;

namespace Fedra.Data.Repositories.Interfaces
{
    public interface IComprobanteRepository : IBaseRepository<Comprobante>
    {
        IQueryable<Comprobante> GetAll(bool includeCategoriasComprobante);
    }
}
