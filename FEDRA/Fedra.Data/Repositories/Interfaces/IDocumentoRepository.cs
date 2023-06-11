using Fedra.Data.Entities;

namespace Fedra.Data.Repositories.Interfaces
{
    public interface IDocumentoRepository : IBaseRepository<Documento>
    {
        IQueryable<Documento> GetAll(bool ConfiguracionDocumento, bool includeTercero, bool includeFormaPago);
    }
}
