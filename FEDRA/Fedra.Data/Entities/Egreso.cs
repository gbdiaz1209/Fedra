namespace Fedra.Data.Entities
{
    public class Egreso
    {
        public long Id { get; set; }
        public long? TerceroId { get; set; }
        public long? Consecutivo { get; set; }
        public DateTime FechaCreación { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string? Observacion { get; set; }
     }
}
