namespace Fedra.Dto.Documento
{
    public class UpdateDocumentoCriteriaDto
    {
        public long Id { get; set; }
        public string? CodigoBarras { get; set; }
        public long? TerceroId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Ajuste { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        /// <summary>
        /// Los estados incluyen 0:Inactivo; 1: Activo; 2: Pagado; 3: Adeudado; 4: Anulado
        /// 0 y 4 reversan los movimientos de inventarios
        /// </summary>
        public int Estado { get; set; }
        public int Condicion { get; set; }
        public long FormaPagoId { get; set; }
        public string? Referencia { get; set; }
        public decimal DineroRecibido { get; set; }
        public decimal Cambio { get; set; }
        public string ModificadoPor { get; set; }
        
    }
}
