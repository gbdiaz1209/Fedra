using Fedra.Dto.Departamento;
using Fedra.Dto.Municipio;
using Fedra.Dto.TipoIdentificacion;

namespace Fedra.Dto.Tercero
{
    public class TerceroDto
    {
        public long Id { get; set; }

        public int Estado { get; set; }
        public TipoIdentificacionDto TipoIdentificacion { get; set; }      
        public string Numero { get; set; } = string.Empty;

        /// <summary>
        /// Tipo de Tercero: si es Cliente o Proveedor
        /// </summary>
        public int Tipo { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Direccion { get; set; }
        public string? Celular { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public DepartamentoDto Departamento { get; set; }
        public MunicipioDto Municipio { get; set; }
        public int? Calificacion { get; set; }
        public string? Observaciones { get; set; }
        public string CreadoPor { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public string ModificadoPor { get; set; } = string.Empty;
        public DateTime FechaModificacion { get; set; }       
    }
}
