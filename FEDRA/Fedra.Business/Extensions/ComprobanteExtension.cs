using Fedra.Data.Entities;
using Fedra.Dto.Comprobante;

namespace Fedra.Business.Extensions
{
    public static class ComprobanteExtension
    {
        public static Comprobante ConvertDtoToEntity(this CreateComprobanteCriteriaDto criteria)
        {
            if (criteria == null)
            {
                return new Comprobante();
            }
            var comprobanteEntity = new Comprobante
            {
                Id = criteria.Id, //estoy cambiando especificando el nombre a la entidad con criteria
                Consecutivo = criteria.Consecutivo,
                Descripcion = criteria.Descripcion,
                Valor = criteria.Valor,
                TerceroId = criteria.TerceroId,
                DocumentoId = criteria.DocumentoId,
                TipoConfiguracionDocumentoId = criteria.TipoConfiguracionDocumentoId,
                EmpresaId = criteria.EmpresaId,
                CreadoPor = criteria.CreadoPor,
                FechaModificacion = DateTime.Now,
                Modificadopor = criteria.ModificadoPor,
                FechaCreacion = DateTime.Now,
            };
            return comprobanteEntity;
        }
        public static ComprobanteDto ConvertEntityToDto(this Comprobante entity)
        {
            if (entity == null)
            {
                return new ComprobanteDto();
            }
            var comprobanteDto = new ComprobanteDto
            {
                Id = entity.Id,
                Consecutivo = entity.Consecutivo,
                Descripcion = entity.Descripcion,
                Valor = entity.Valor,
                CategoriasComprobante = new CategoriasComprobanteDto 
                {
                    Id = entity.CategoriasComprobante != null ? entity.CategoriasComprobante.Id : 0,
                    Descripcion = entity.Descripcion != null ? entity.CategoriasComprobante.Descripcion : string.Empty,
                    TipoConfiguracionDocumentoId = entity.CategoriasComprobante != null ? entity.CategoriasComprobante.TipoConfiguracionDocumentoId : 0,
                },
                TerceroId = entity.TerceroId,
                DocumentoId = entity.DocumentoId,
                TipoConfiguracionDocumentoId = entity.TipoConfiguracionDocumentoId,
                EmpresaId = entity.EmpresaId,
                CreadoPor = entity.CreadoPor,
                FechaModificacion = DateTime.Now,
                Modificadopor = entity.Modificadopor,
                FechaCreacion = DateTime.Now,
            };
            return comprobanteDto;
        }
    }
}
