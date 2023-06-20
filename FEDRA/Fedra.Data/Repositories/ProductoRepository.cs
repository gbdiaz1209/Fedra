using Fedra.Data.Context;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Data.Repositories
{
    public class ProductoRepository : BaseRepository<Producto>, IProductoRepository
    {
        protected FedraDbContext _context;
        public ProductoRepository(FedraDbContext context) : base(context)
        {
            _context = context;
        }


        //Propiedades de navegacion
        public IQueryable<Producto> GetAll(bool includeUnidadMedida, bool includeCategoria)
        {
            var query = GetAll();

            if (includeUnidadMedida)
            {
                query = query.Include(productoEntity => productoEntity.UnidadMedida);
            }
            if (includeCategoria)
            {
                query = query.Include(productoEntity => productoEntity.Categoria);
            }
            return query;
        }
    }
}
    
    