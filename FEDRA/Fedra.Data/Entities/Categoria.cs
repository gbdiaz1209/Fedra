namespace Fedra.Data.Entities
{
    public class Categoria
    {
        public long Id { get; set; }
        public string? Descripcion { get; set; }
        public long? EmpresaId { get; set; }

        public int Estado { get; set; }



    }
}
