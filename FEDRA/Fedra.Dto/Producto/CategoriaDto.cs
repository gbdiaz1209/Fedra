namespace Fedra.Dto.Producto
{
    public class CategoriaDto
    {
        public long Id { get; set; }
        public string? Descripcion { get; set; }
        public long? EmpresaId { get; set; }

        public int Estado { get; set; }


    }
}