using Fedra.Business.ValidationServices.Interfaces;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;
using Fedra.Dto.Tercero;
using Fedra.Dto.Validation;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Business.ValidationServices
{
    public class TerceroValidationService : ITerceroValidationService
    {
        //inyectar la dependencia del repositorio, porque tenemos que validar que existe.
        
        private readonly ITerceroRepository _terceroRepository;
       
        public TerceroValidationService(ITerceroRepository terceroRepository)
        {
            _terceroRepository = terceroRepository;
        }

        public async Task<ValidationResultDto> ValidateForCreate(CreateTerceroCriteriaDto criteria)
        {
            var result = new ValidationResultDto();

            //Valida que el tercero con el numero de identificacion no exist
            var validarExistencia = await ValidarExistencia(criteria);

            if(!string.IsNullOrEmpty(validarExistencia.Mensaje))
            {
                result.Mensajes.Add(validarExistencia);
            }

            return result;
        }

        public async Task<(ValidationResultDto Validaciones, Tercero TerceroEntity)> ValidateForUpdate
                                                                                    (UpdateTerceroCriteriaDto criteria)
        {
            var validationResult = new ValidationResultDto();

            //Valida que el tercero con id exista
            var result = await ValidarExistenciaPorId(criteria.Id);

            if (!string.IsNullOrEmpty(result.Validacion.Mensaje))
            {
                validationResult.Mensajes.Add(result.Validacion);
            }

            return (validationResult, result.TerceroEntity); 
        }

        public async Task<(ValidationResultDto Validaciones, Tercero TerceroEntity)>
            ValidateForUpdateEstado(UpdateEstadoCriteriaDto criteria)
        {
            var validationResult = new ValidationResultDto();

            //Valida que el tercero con el numero de identificacion 
            var result = await ValidarExistenciaPorId(criteria.TerceroId);

            if (!string.IsNullOrEmpty(result.Validacion.Mensaje))
            {
                validationResult.Mensajes.Add(result.Validacion); 
            }

            return (validationResult, result.TerceroEntity);
        }

        private async Task<ValidationConditionDto> ValidarExistencia(CreateTerceroCriteriaDto criteria)
        {
            var result = new ValidationConditionDto();

            var terceroEntity = await _terceroRepository.GetAll().FirstOrDefaultAsync(t => t.Numero == criteria.Numero);

            if (terceroEntity != null)
            {

                result.Mensaje = "El Tercero ya existe";

                return result;
            }

            return result;
        }

        private async Task<(ValidationConditionDto Validacion , Tercero TerceroEntity)> ValidarExistenciaPorId
                                                                                                (long TerceroId)
        {
            var result = new ValidationConditionDto();

            var terceroEntity = await _terceroRepository.GetAll().FirstOrDefaultAsync(t => t.Id == TerceroId);

            if (terceroEntity == null)
            {

                result.Mensaje = "El Tercero no existe";

                return (result, null);
            }


            return (result, terceroEntity);
        }
    }
}
