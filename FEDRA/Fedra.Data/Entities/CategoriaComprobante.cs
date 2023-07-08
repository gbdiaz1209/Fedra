namespace Fedra.Data.Entities
{
    public class CategoriaComprobante
    {
        public long Id { get; set; }
        public string? Descripcion { get; set; }
        public long? TipoConfiguracionDocumentoId { get; set;}
    }
}
