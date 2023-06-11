using Fedra.Data.Context;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Data.Repositories
{
    public class DocumentoRepository : BaseRepository<Documento>, IDocumentoRepository
    {
        protected FedraDbContext _context;

        public DocumentoRepository(FedraDbContext context) : base(context)
        {
            _context = context;
        }

        //Incluyeme las propiedades de navegacion
        public IQueryable<Documento> GetAll(bool includeConfiguracionDocumento, bool includeTercero, bool includeFormaPago)
        {
            var query = GetAll();

            if (includeConfiguracionDocumento)
            {
                query = query.Include(terceroEntity => terceroEntity.ConfiguracionDocumento);
            }
            if (includeTercero)
            {
                query = query.Include(terceroEntity => terceroEntity.Tercero);
            }
            if (includeFormaPago)
            {
                query = query.Include(terceroEntity => terceroEntity.FormaPago);
            }

            return query;

        }
    }

}
