﻿namespace Fedra.Data.Entities
{
    public class Documento
    {
        public long Id { get; set; }
        public long TipoConfiguracionDocumentoId { get; set; }
        public string? CodigoBarras { get; set; }
        public long Consecutivo { get; set; }
        public long TerceroId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Ajuste { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        /// <summary>
        /// Los estados incluyen 0:Inactivo; 1: Activo; 2: Pagado; 3: Adeudado; 4: Anulado
        /// 0 y 4 reversan los movimientos de inventarios
        /// </summary>
        public int Estado { get; set; }
        public long EmpresaId { get; set; }
        public int Condicion { get; set; }
        public long FormaPagoId { get; set; }
        public string? Referencia { get; set; }
        public decimal DineroRecibido { get; set; }
        public decimal Cambio { get; set; }
        public string? CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string ModificadoPor { get; set; } 
        public DateTime FechaModificacion { get; set; }

        /// <summary>
        /// Propiedades de navegacion
        /// </summary>

        public ConfiguracionDocumento? ConfiguracionDocumento { get; set; }
        public Tercero? Tercero { get; set; }
        public FormaPago? FormaPago { get; set; }


    }
}
