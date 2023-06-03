using Fedra.Data.Context;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;

namespace Fedra.Data.Repositories
{
    public class ExencionRepository : BaseRepository<Exencion>, IExencionRepository
    {
        protected FedraDbContext _context;

        public ExencionRepository(FedraDbContext context) : base(context)
        {
            _context = context;
        }
    }

}
