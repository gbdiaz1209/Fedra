using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedra.Dto.Producto
{
    public class ProductoDto
    {
        public long Id { get; set; }
        public string? Codigo { get; set; }
        public string? CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public long? UnidadMedidaId { get; set; }
        public long? CategoriaId { get; set; }
        public decimal? CostoPonderado { get; set; }
        public decimal? PrecioVenta { get; set; }
        public int? StockMinimo { get; set; }
        public int? StockActual { get; set; }
        public int? StockMaximo { get; set; }
        public string? Ubicacion { get; set; }
        public long EmpresaId { get; set; }
        /// <summary>
        /// ESTADO : 1 Para Activo 0 para Inactivo
        /// </summary>
        public int? Estado { get; set; }
        public string? CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? ModificadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }

        /// <summary>
        /// Propiedades de navegacion
        /// </summary>
        public Categoria Categoria { get; set; }
        public UnidadMedida UnidadMedida { get; set; }

    }
}
