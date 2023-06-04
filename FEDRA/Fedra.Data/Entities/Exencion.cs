namespace Fedra.Data.Entities
{
    public class Exencion
    {
        public long Id { get; set; }
        public long? TerceroId { get; set; }
        public long? ProductoId { get; set; }
        public long? ImpuestoId { get; set; }
        public string? Observacion { get; set; }

        //Propiedades de Navegacion

        public Tercero? Tercero { get; set; }

        //public Producto? Producto { get; set; } TODO: descomentar cuando se cree el producto

        public Impuesto Impuesto { get; set; } = new Impuesto();
    }
}
