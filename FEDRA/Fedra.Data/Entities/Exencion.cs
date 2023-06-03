namespace Fedra.Data.Entities
{
    public class Exencion
    {
        public long Id { get; set; }
        public long? TerceroId { get; set; }
        public long? ProductoId { get; set; }
        public long? ImpuestoId { get; set; }
        public string? Observacion { get; set; }

    }
}
