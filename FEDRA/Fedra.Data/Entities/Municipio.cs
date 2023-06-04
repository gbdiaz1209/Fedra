namespace Fedra.Data.Entities
{
    public class Municipio
    {
        public long Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string DepartamentoId { get; set; } = string.Empty;

        //Propiedades de Navegacion
        public Departamento Departamento { get; set; } = new Departamento();
    }
}
