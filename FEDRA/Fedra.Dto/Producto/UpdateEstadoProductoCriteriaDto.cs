namespace Fedra.Dto.Producto
{
    public class UpdateEstadoProductoCriteriaDto
    {
        public object ProductoId;

        public long Id { get; set; }

        public int Estado { get; set; }

        public string? ModificadoPor { get; set; }
        public string Nombre { get; set; }
    }
}
}
