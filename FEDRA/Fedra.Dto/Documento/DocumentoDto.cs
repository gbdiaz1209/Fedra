
using Fedra.Dto.Tercero;
using Fedra.Dto.ConfiguracionDocumento;
using Fedra.Dto.FormaPago;

namespace Fedra.Dto.Documento
{
    public class DocumentoDto
    {
        public long Id { get; set; }
        public ConfiguracionDocumentoDto ConfiguracionDocumento { get; set; }
        public string CodigoBarras { get; set; } = string.Empty;
        public long Consecutivo { get; set; }
        public TerceroDto Tercero { get; set; }
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
        public int Condicion { get; set; }
        public FormaPagoDto FormaPago { get; set; }
        public string Referencia { get; set; } = string.Empty;
        public Decimal DineroRecibido { get; set; }
        public Decimal Cambio { get; set; }
        public string CreadoPor { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public string ModificadoPor { get; set; } = string.Empty;
        public DateTime FechaModificacion { get; set; }

        

    }
}

