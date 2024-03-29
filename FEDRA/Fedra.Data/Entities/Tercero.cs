﻿namespace Fedra.Data.Entities
{
    public class Tercero
    {
        public long Id { get; set; }
        public long EmpresaId { get; set; }
        public long TipoIdentificacionId { get; set; }
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
        public long? DepartamentoId { get; set; }
        public long? MunicipioId { get; set; }
        public int? Calificacion { get; set; }
        public string? Observaciones { get; set; }
        public string CreadoPor { get; set; } = string.Empty;       
        public DateTime FechaCreacion { get; set; }
        public string ModificadoPor { get; set; } = string.Empty;
        public DateTime FechaModificacion { get; set; }
        public int Estado { get; set; }

        //Propiedades de navegacion
        public Departamento? Departamento { get; set; }
        public Municipio? Municipio { get; set; }
        public TipoIdentificacion? TipoIdentificacion { get; set; }


    }
}
