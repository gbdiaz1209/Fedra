using Fedra.Data.Context;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Data.Repositories
{
    public class ComprobanteRepository : BaseRepository<Comprobante>, IComprobanteRepository
    {
        protected FedraDbContext _context;
        public ComprobanteRepository(FedraDbContext context) : base(context)
        {
            _context = context;
        }
        //Propiedades de navegacion
        public IQueryable<Comprobante> GetAll(bool includeCategoriasComprobante)
        {
            var query = GetAll();

            if (includeCategoriasComprobante)
            {
                query = query.Include(ComprobanteEntity => ComprobanteEntity.CategoriaComprobante);
            }
            return query;
        }
     }
}
