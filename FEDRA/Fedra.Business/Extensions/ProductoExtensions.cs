using Fedra.Business.Constants;
using Fedra.Data.Entities;
using Fedra.Dto.Producto;


namespace Fedra.Business.Extensions
{
    // las extenciones deben ser de clases estaticas
    public static class ProductoExtensions
        {
         
            public static Producto ConvertDtoToEntity(this CreateProductoCriteriaDto criteria)
            {
                if (criteria == null)
                {
                    return new Producto();
                }

                var productoEntity = new Producto

                {
                    Codigo = criteria.Codigo,
                    CodigoBarras = criteria.CodigoBarras,
                    Nombre = criteria.Nombre,
                    UnidadMedidaId = criteria.UnidadMedidaId,
                    CategoriaId = criteria.CategoriaId,
                    CostoPonderado = criteria.CostoPonderado,
                    PrecioVenta = criteria.PrecioVenta,
                    StockMinimo = criteria.StockMinimo,
                    StockActual = criteria.StockActual,
                    StockMaximo = criteria.StockMaximo,
                    Ubicacion = criteria.Ubicacion,
                    EmpresaId = criteria.EmpresaId,
                    Estado = (int)EstadoActivacion.Activo,
                    CreadoPor = criteria.CreadoPor,
                    ModificadoPor = criteria.CreadoPor,
                    FechaCreacion = DateTime.Now,
                    FechaModificacion = DateTime.Now,
                };

                return productoEntity;
            }

            public static ProductoDto ConvertEntityToDto(this Producto entity)
            {
                if (entity == null)
                {
                    return new ProductoDto();
                }

                var productoDto = new ProductoDto
                {

                    Id = entity.Id, 
                    Codigo = entity.Codigo,
                    CodigoBarras = entity.CodigoBarras,
                    Nombre = entity.Nombre,                    
                    UnidadMedida = new UnidadMedidaDto
                    {
                        Id = entity.UnidadMedida != null ? entity.UnidadMedida.Id : 0,
                        Nombre = entity.UnidadMedida != null ? entity.UnidadMedida.Nombre: string.Empty,
                        Simbolo = entity.UnidadMedida != null ? entity.UnidadMedida.Simbolo : string.Empty
                    },

                    Categoria = new CategoriaDto
                    {
                        Id = entity.Categoria != null ? entity.Categoria.Id : 0,
                        Estado = entity.Categoria != null ? entity.Categoria.Estado : 0,
                        Descripcion = entity.Categoria != null ? entity.Categoria.Descripcion : string.Empty,
                        EmpresaId = entity.Categoria != null ? entity.Categoria.EmpresaId : 0,
                   
                    },
                    CostoPonderado = entity.CostoPonderado,
                    PrecioVenta = entity.PrecioVenta,
                    StockMinimo = entity.StockMinimo,
                    StockActual = entity.StockActual,
                    StockMaximo = entity.StockMaximo,
                    Ubicacion = entity.Ubicacion,
                    EmpresaId = entity.EmpresaId,
                    Estado = (int)EstadoActivacion.Activo,
                    ModificadoPor = entity.ModificadoPor,
                    CreadoPor = entity.CreadoPor,
                    FechaCreacion = DateTime.Now,
                    FechaModificacion = DateTime.Now
                };

                return productoDto;
            }
     }
 }
