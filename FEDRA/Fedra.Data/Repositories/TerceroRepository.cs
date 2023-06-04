using Fedra.Data.Context;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;

namespace Fedra.Data.Repositories
{
    public class TerceroRepository : BaseRepository<Tercero>, ITerceroRepository
    {
        protected FedraDbContext _context;

        public TerceroRepository(FedraDbContext context) : base(context)
        {
            _context = context;
        }

        //Incluyeme las propiedades de navegacion
    }
}