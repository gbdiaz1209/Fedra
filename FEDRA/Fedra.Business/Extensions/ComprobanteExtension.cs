using Fedra.Business.Constants;
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
                Consecutivo = criteria.Consecutivo,
                Descripcion = criteria.Descripcion,
                Valor = criteria.Valor,
                TerceroId = criteria.TerceroId,
                DocumentoId = criteria.DocumentoId,
                TipoConfiguracionDocumentoId = criteria.TipoConfiguracionDocumentoId,
                CategoriaComprobanteId = criteria.CategoriaComprobanteId,
                FormaPagoId = criteria.FormaPagoId,
                ReferenciaPago = criteria.ReferenciaPago,
                EmpresaId = criteria.EmpresaId,
                Estado = (int)EstadoActivacion.Activo,
                CreadoPor = criteria.CreadoPor,
                FechaModificacion = DateTime.Now,
                Modificadopor = criteria.CreadoPor,
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
                CategoriaComprobanteId = entity.CategoriaComprobanteId != null ? entity.CategoriaComprobanteId : 0,
                CategoriasComprobante = new CategoriasComprobanteDto 
                {
                    Id = entity.CategoriaComprobante != null ? entity.CategoriaComprobante.Id : 0,
                    Descripcion = entity?.CategoriaComprobante?.Descripcion != null ? entity.CategoriaComprobante.Descripcion : string.Empty,
                    TipoConfiguracionDocumentoId = entity?.CategoriaComprobante?.TipoConfiguracionDocumentoId != null ? entity.CategoriaComprobante.TipoConfiguracionDocumentoId : 0,
                },
                TerceroId = entity.TerceroId != null ? entity.TerceroId : 0,
                FormaPagoId = entity.FormaPago != null ? entity.FormaPago.Id : 0,
                FormaPago = new FormaPagoDto
                {
                    Id = entity.FormaPago != null ? entity.FormaPago.Id : 0,
                    Descripcion = entity?.FormaPago?.Descripcion != null ? entity.FormaPago.Descripcion: string.Empty,
                },
                Estado = entity.Estado,
                DocumentoId = entity.DocumentoId != null ? entity.DocumentoId : 0,
                
                TipoConfiguracionDocumentoId = entity.TipoConfiguracionDocumentoId,
                EmpresaId = entity.EmpresaId,
                CreadoPor = entity.CreadoPor,
                FechaModificacion =  entity.FechaModificacion,
                Modificadopor = entity.Modificadopor,
                FechaCreacion = entity.FechaCreacion,
            };
            return comprobanteDto;
        }
    }
}
