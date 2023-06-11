namespace Fedra.Data.Entities
{
    public class Documento
    {
        public long Id { get; set; }
        public long TipoConfiguracionDocumentoId { get; set; }
        public string CodigoBarras { get; set; } = string.Empty;
        public long Consecutivo { get; set; }
        public long TerceroId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public Decimal Subtotal { get; set; }
        public Decimal Ajuste { get; set; }
        public Decimal Descuento { get; set; }
        public Decimal Total { get; set; }

        /// <summary>
        /// Los estados incluyen 0:Inactivo; 1: Activo; 2: Pagado; 3: Adeudado; 4: Anulado
        /// 0 y 4 reversan los movimientos de inventarios
        /// </summary>
        public int Estado { get; set; }
        public long EmpresaId { get; set; }
        public int Condicion { get; set; }
        public long FormaPagoId { get; set; }
        public string Referencia { get; set; } = string.Empty;
        public Decimal DineroRecibido { get; set; }
        public Decimal Cambio { get; set; }
        public string CreadoPor { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public string ModificadoPor { get; set; } = string.Empty;
        public DateTime FechaModificacion { get; set; }

        /// <summary>
        /// Propiedades de navegacion
        /// </summary>

        public ConfiguracionDocumento? ConfiguracionDocumento { get; set; }
        public Tercero? Tercero { get; set; }
        public FormaPago? FormaPago { get; set; }


    }
}
