using Fedra.Data.Context;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;

namespace Fedra.Data.Repositories
{
    public class MunicipioRepository : BaseRepository<Municipio>, IMunicipioRepository
    {
        protected FedraDbContext _context;

        public MunicipioRepository(FedraDbContext context) : base(context)
        {
            _context = context;
        }
    }

}
