namespace Fedra.Data.Entities
{
    public class Municipio
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public string DepartamentoId { get; set; }

        ////Propiedades de Navegacion
        //public Departamento Departamento { get; set; }
    }
}
