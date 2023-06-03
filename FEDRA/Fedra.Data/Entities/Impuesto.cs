namespace Fedra.Data.Entities
{
    public class Impuesto
    {
        public long Id { get; set; }
        public long? EmpresaId { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Porcentaje { get; set; }

    }
}
