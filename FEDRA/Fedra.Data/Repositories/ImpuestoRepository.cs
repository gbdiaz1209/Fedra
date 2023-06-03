using Fedra.Data.Context;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;

namespace Fedra.Data.Repositories
{
    public class ImpuestoRepository : BaseRepository<Impuesto>, IImpuestoRepository
    {
        protected FedraDbContext _context;

        public ImpuestoRepository(FedraDbContext context) : base(context)
        {
            _context = context;
        }
    }

}
