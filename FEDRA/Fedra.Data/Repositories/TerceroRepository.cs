using Fedra.Data.Context;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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
        public IQueryable<Tercero> GetAll(bool includeTipoIdentificacion, bool includeDepartamento, bool includeMunicipio)
        {
            var query = GetAll();

            if (includeTipoIdentificacion)
            {
                query = query.Include(terceroEntity => terceroEntity.TipoIdentificacion);
            }
            if (includeDepartamento)
            {
                query = query.Include(terceroEntity => terceroEntity.Departamento);
            }
            if (includeMunicipio)
            {
                query = query.Include(terceroEntity => terceroEntity.Municipio);
            }

            return query;
        }
    }
}