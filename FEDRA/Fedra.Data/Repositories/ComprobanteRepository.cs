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
        public IQueryable<Comprobante> GetAll(bool includeIngreso, bool includeEgreso)
        {
            var query = GetAll();

            if (includeIngreso)
            {
                query = query.Include(ComprobanteEntity => comprobanteEntity.Ingreso);
            }
            if (includeEgreso)
            {
                query = query.Include(productoEntity => comprobanteEntity.Egreso);
            }
            return query;
        }
    }
}
