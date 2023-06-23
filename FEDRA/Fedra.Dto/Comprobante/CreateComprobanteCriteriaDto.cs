namespace Fedra.Dto.Comprobante
{
    public class CreateComprobanteCriteriaDto
    {
        public long Id { get; set; }
        public long? Consecutivo { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Valor { get; set; }
        public long? TerceroId { get; set; }
        public long? DocumentoId { get; set; }
        public long? TipoConfiguracionDocumentoId { get; set; }
        public long EmpresaId { get; set; }
        public string? CreadoPor { get; set; } 
        public DateTime FechaCreacion { get; set; }
        public string? ModificadoPor { get; set; } 
        public DateTime? FechaModificacion { get; set; }

    }
}
