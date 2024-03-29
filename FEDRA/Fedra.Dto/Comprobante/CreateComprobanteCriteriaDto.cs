﻿namespace Fedra.Dto.Comprobante
{
    public class CreateComprobanteCriteriaDto
    {
        //para el create nunca se manda el ID porque la base de dato lo genera
        public long? Consecutivo { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Valor { get; set; }
        public long? TerceroId { get; set; }
        public long? DocumentoId { get; set; }
        public long? TipoConfiguracionDocumentoId { get; set; }
        public long? CategoriaComprobanteId { get; set; }
        public long EmpresaId { get; set; }
        public long? FormaPagoId { get; set; }       
        public string ReferenciaPago { get; set; }
        public string? CreadoPor { get; set; }                                
    }
}
