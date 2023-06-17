namespace Fedra.Dto.Producto
{
    public class CreateProductoCriteriaDto
    {
        public string? Codigo { get; set; }
        public string? CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public long? UnidadMedidaId { get; set; }
        public long? CategoriaId { get; set; }
        public decimal? CostoPonderado { get; set; }
        public decimal? PrecioVenta { get; set; }
        public int? StockMinimo { get; set; }
        public int? StockActual { get; set; }
        public int? StockMaximo { get; set; }
        public string? Ubicacion { get; set; }
        public long EmpresaId { get; set; }
        public int? Estado { get; set; }
        public string? CreadoPor { get; set; }     
    }
}

