using Fedra.Business.Constants;
using Fedra.Business.DomainServices.Interfaces;
using Fedra.Business.Extensions;
using Fedra.Business.ValidationServices.Interfaces;
using Fedra.Data.Repositories.Interfaces;
using Fedra.Dto.Producto;
using Fedra.Dto.Validation;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Business.DomainServices
{   
    public class ProductoDomainService : IProductoDomainService
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IProductoValidationService _productoValidationService;

        public ProductoDomainService(IProductoRepository productoRepository, IProductoValidationService productoValidationService)
        {
            _productoRepository = productoRepository;
            _productoValidationService = productoValidationService;
        }

        public async Task<(ValidationResultDto Validaciones, ProductoDto Producto)> CreateProductoAsync(CreateProductoCriteriaDto criteria)
        {
            //servicio de validacion  / validarlo
            var validationResult = await _productoValidationService.ValidateForCreate(criteria);

            if (validationResult.Mensajes.Any())
            {
                return (validationResult, null);
            }

            // Si es valido, usar el repositorio de producto para crearlo

            //Mapear criteria DTO a la entidad
            var productoEntity = criteria.ConvertDtoToEntity();

            // usar el producto repositorio para guardar la fila en la tabla.
            _productoRepository.Add(productoEntity);
            await _productoRepository.SaveChangesAsync();

            //mapear/convertir la entidad que me devuelve EF al DTO que necesito mandarle al la capa superior
            var dto = productoEntity.ConvertEntityToDto();

            //retornar el DTO
            return (validationResult, dto);
        }

        public async Task<(ValidationResultDto Validaciones, ProductoDto Producto)> UpdateProductoAsync(UpdateProductoCriteriaDto criteria)

        {
            // validar el criteria - que exista
            var result = await _productoValidationService.ValidateForUpdate(criteria);

            if (result.Validaciones.Mensajes.Any())
            {
                return (result.Validaciones, null); //en este result tengo la entidad que fue buscada esa es la que
                                                    //voy a cambiar
            }
            //convertir dto a entidad para llegar al repositorio


            var entity = result.ProductoEntity;

            entity.Id = criteria.Id; //estoy cambiando especificando el nombre a la entidad con criteria
            entity.Codigo = criteria.Codigo;
            entity.CodigoBarras = criteria.CodigoBarras;
            entity.Nombre = criteria.Nombre;
            entity.UnidadMedidaId = criteria.UnidadMedidaId;
            entity.CategoriaId = criteria.CategoriaId;
            entity.CostoPonderado = criteria.CostoPonderado;
            entity.PrecioVenta = criteria.PrecioVenta;
            entity.StockMinimo = criteria.StockMinimo;
            entity.StockActual = criteria.StockActual;
            entity.StockMaximo = criteria.StockMaximo;
            entity.Ubicacion = criteria.Ubicacion;
            entity.EmpresaId = criteria.EmpresaId;
            entity.Estado = (int)EstadoActivacion.Activo;
            entity.ModificadoPor = criteria.ModificadoPor;
            entity.FechaModificacion = DateTime.Now;
            //ya tengo la entidad
            _productoRepository.Update(entity); // usar el repositorio y le paso la entidad

            await _productoRepository.SaveChangesAsync();// guarda los cambios

            var dto = entity.ConvertEntityToDto(); // cambio la entidad a dto

            return (new ValidationResultDto(), dto);
        }

        public async Task<(ValidationResultDto Validaciones, ProductoDto Producto)> UpdateEstadoProductoAsync(UpdateEstadoProductoCriteriaDto criteria)

        {
            // validar el criteria - que exista
            var result = await _productoValidationService.ValidateForUpdateEstado(criteria);

            if (result.Validaciones.Mensajes.Any())
            {
                return (result.Validaciones, null);
                //en este result tengo la validacion que fue buscada.esa es la que
                //voy a cambiar

            }

            var entity = result.ProductoEntity;

            //convertir dto a entidad para llegar al repositorio

            entity.Estado = criteria.Estado;
            entity.ModificadoPor = criteria.ModificadoPor;
            entity.FechaModificacion = DateTime.Now;

            _productoRepository.Update(entity);

            await _productoRepository.SaveChangesAsync();

            var dto = entity.ConvertEntityToDto();// cambio la entidad a dto

            return (new ValidationResultDto(), dto); //devuelve la validacion y el dto de criteria actualizado
        }


        public async Task<List<ProductoDto>> GetProductoPorEstadoAsync(long Id, string nombre)
        {
            var productosBuscados = await _productoRepository
                                                           .GetAll(true, false)
                                                           .Where(t => t.EmpresaId == Id &&
                                                                    t.Nombre == nombre)
                                                           .ToListAsync();

            //seleccionar producto por producto y convertirlo a dto
            var productosComoDto = productosBuscados.Select(tb => tb.ConvertEntityToDto()).ToList();

            return productosComoDto;




        }

    } 
    

}