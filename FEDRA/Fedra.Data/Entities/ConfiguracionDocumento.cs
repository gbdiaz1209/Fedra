namespace Fedra.Data.Entities
{
    public class ConfiguracionDocumento
    {
        public long Id { get; set; }
        public long EmpresaId { get; set; }
        public string NombreDocumento { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string Prefijo { get; set; } = string.Empty;
        public string Sufijo { get; set; } = string.Empty;
        public bool AfectaInventario { get; set; }
        public long ConsecutivoInicial { get; set; }
        public long ConsecutivoActual { get; set; }
        public long ConsecutivoFinal { get; set; }
        public string Mensaje { get; set; } = string.Empty;
        public string Mensaje2 { get; set; } = string.Empty;
        
    }
}
