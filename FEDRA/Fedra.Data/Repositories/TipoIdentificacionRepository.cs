using Fedra.Data.Context;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;

namespace Fedra.Data.Repositories
{
    public class TipoIdentificacionRepository : BaseRepository<TipoIdentificacion>, ITipoIdentificacionRepository
    {
        protected FedraDbContext _context;

        public TipoIdentificacionRepository(FedraDbContext context) : base(context)
        {
            _context = context;
        }
    }

}