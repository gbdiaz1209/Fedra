namespace Fedra.Dto.ConfiguracionDocumento
{
    public class ConfiguracionDocumentoDto
    {
        public long Id { get; set; }
        public long EmpresaId { get; set; }
        public string? NombreDocumento { get; set; }
        public string? Codigo { get; set; }
        public string? Prefijo { get; set; }
        public string? Sufijo { get; set; }
        public bool AfectaInventario { get; set; }
        public long ConsecutivoInicial { get; set; }
        public long ConsecutivoActual { get; set; }
        public long ConsecutivoFinal { get; set; }
        public string? Mensaje { get; set; }
        public string? Mensaje2 { get; set; }

    }
}
