using Fedra.Data.Context;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Data.Repositories
{
    public class ProductoRepository : BaseRepository<ProductoRepository>, IProductoRepository
    {
        protected FedraDbContext _context;
        public ProductoRepository(FedraDbContext context) : base(context)
        {
            _context = context;
        }

        public object UnidadMedidadId { get; private set; }
        public object CategoriaId { get; private set; }

        //Propiedades de navegacion
        public IQueryable<Producto> GetAll(bool includeUnidadMedidaId, bool includeCategoriaId)
        {
            var query = GetAll();

            if (includeUnidadMedidaId)
            {
                query = query.Include(terceroEntity => terceroEntity.UnidadMedidadId);
            }
            if (includeCategoriaId)
            {
                query = query.Include(terceroEntity => terceroEntity.CategoriaId);
            }
            return (IQueryable<Producto>)query;
        }
    }
}
    
    