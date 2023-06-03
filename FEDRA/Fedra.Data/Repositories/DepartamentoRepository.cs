using Fedra.Data.Context;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;

namespace Fedra.Data.Repositories
{
    public class DepartamentoRepository : BaseRepository<Departamento>, IDepartamentoRepository
    {
        protected FedraDbContext _context;

        public DepartamentoRepository(FedraDbContext context) : base(context)
        {
            _context = context;
        }
    }

}