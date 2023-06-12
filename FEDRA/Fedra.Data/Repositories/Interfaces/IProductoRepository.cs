using Fedra.Data.Entities;

namespace Fedra.Data.Repositories.Interfaces
{
    public interface IProductoRepository : IBaseRepository<Producto>
    {
        IQueryable<Producto> GetAll(bool includeUnidadMedida, bool includeCategoria);
    }
}
