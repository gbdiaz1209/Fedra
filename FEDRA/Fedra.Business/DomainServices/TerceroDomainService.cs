using Fedra.Business.DomainServices.Interfaces;
using Fedra.Business.Extensions;
using Fedra.Business.ValidationServices.Interfaces;
using Fedra.Data.Repositories.Interfaces;
using Fedra.Dto.Tercero;
using Fedra.Dto.Validation;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Business.DomainServices
{
    public class TerceroDomainService : ITerceroDomainService
    {
        private readonly ITerceroRepository _terceroRepository;
        private readonly ITerceroValidationService _terceroValidationService;

        public TerceroDomainService(ITerceroRepository terceroRepository, ITerceroValidationService terceroValidationService)
        {
            _terceroRepository = terceroRepository;
            _terceroValidationService = terceroValidationService;
        }

        public async Task<(ValidationResultDto Validaciones, TerceroDto Tercero)> CreateTerceroAsync(CreateTerceroCriteriaDto criteria)
        {
            //servicio de validacion  / validarlo
            var validationResult = await _terceroValidationService.ValidateForCreate(criteria);

            if (validationResult.Mensajes.Any())
            {
                return (validationResult, null);
            }

            // Si es valido, usar el repositorio de tercero para crearlo

            //Mapear criteria DTO a la entidad
            var terceroEntity = criteria.ConvertDtoToEntity();

            // usar el tercero repositorio para guardar la fila en la tabla.
            _terceroRepository.Add(terceroEntity);
            await _terceroRepository.SaveChangesAsync();

            //mapear/convertir la entidad que me devuelve EF al DTO que necesito mandarle al la capa superior
            var dto = terceroEntity.ConvertEntityToDto();
            
            //retornar el DTO
            return (validationResult, dto);
        }

        public async Task<(ValidationResultDto Validaciones, TerceroDto Tercero)> 
            UpdateTerceroAsync(UpdateTerceroCriteriaDto criteria)
        {  
            // validar el criteria - que exista
            var result = await _terceroValidationService.ValidateForUpdate(criteria);

            if (result.Validaciones.Mensajes.Any())
            {
                return (result.Validaciones, null); //en este result tengo la entidad que fue buscada.esa es la que
                                                    //voy a cambiar
            }
            //convertir dto a entidad para llegar al repositorio
            

            var entity = result.TerceroEntity;

            entity.Nombre = criteria.Nombre; //estoy cambiando especificando el nombre a la entidad con criteria
            entity.TipoIdentificacionId = criteria.TipoIdentificacionId;
            entity.Numero = criteria.Numero;
            entity.Tipo = criteria.Tipo;
            entity.Nombre = criteria.Nombre;
            entity.Direccion = criteria.Direccion;
            entity.Celular = criteria.Celular;
            entity.Telefono = criteria.Telefono;
            entity.Email = criteria.Email;
            entity.DepartamentoId = criteria.DepartamentoId;
            entity.MunicipioId = criteria.MunicipioId;
            entity.Calificacion = criteria.Calificacion;
            entity.Observaciones = criteria.Observaciones;
            entity.ModificadoPor = criteria.ModificadoPor;
            entity.FechaModificacion = DateTime.Now;
            //ya tengo la entidad
            _terceroRepository.Update(entity); // usar el repositorio y le paso la entidad

            await _terceroRepository.SaveChangesAsync();// guarda los cambios

            var dto = entity.ConvertEntityToDto(); // cambio la entidad a dto

            return (new ValidationResultDto(), dto);
        }

        public async Task<(ValidationResultDto Validaciones, TerceroDto Tercero)>
                                                               UpdateEstadoTerceroAsync(UpdateEstadoCriteriaDto criteria)
        {
            // validar el criteria - que exista
            var result = await _terceroValidationService.ValidateForUpdateEstado(criteria);

            if (result.Validaciones.Mensajes.Any())
            {
                return (result.Validaciones, null);
                //en este result tengo la validacion que fue buscada.esa es la que
                //voy a cambiar

            }

            var entity = result.TerceroEntity;

            //convertir dto a entidad para llegar al repositorio

            entity.Estado = criteria.Estado;
            entity.ModificadoPor = criteria.ModificadoPor;
            entity.FechaModificacion = DateTime.Now;

            _terceroRepository.Update(entity);

            await _terceroRepository.SaveChangesAsync();

            var dto = entity.ConvertEntityToDto();// cambio la entidad a dto

            return (new ValidationResultDto(), dto); //devuelve la validacion y el dto de criteria actualizado
        }


        public async Task<List<TerceroDto>> GetTerceroPorEstadoAsync(long empresaId, int estado)
        {
            var tercerosBuscados = await _terceroRepository
                                                           .GetAll()
                                                           .Where(t => t.EmpresaId == empresaId &&
                                                                    t.Estado == estado)
                                                           .ToListAsync();

            //seleccionar tercero por tercero y convertirlo a dto
            var tercerosComoDto = tercerosBuscados.Select(tb => tb.ConvertEntityToDto()).ToList();

            return tercerosComoDto;
        }
    }
}
