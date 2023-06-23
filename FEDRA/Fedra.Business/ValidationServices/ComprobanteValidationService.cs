using Fedra.Business.ValidationServices.Interfaces;
using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;
using Fedra.Dto.Comprobante;
using Fedra.Dto.Validation;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Business.ValidationServices
{
    public class ComprobanteValidationService : IComprobanteValidationService
  
    {

        //inyectar la dependencia del repositorio, porque tenemos que validar que existe.

        private readonly IComprobanteRepository _comprobanteRepository;

        public ComprobanteValidationService(IComprobanteRepository comprobanteRepository)
        {
            _comprobanteRepository = comprobanteRepository;
        }


        public async Task<ValidationResultDto> ValidateForCreate(CreateComprobanteCriteriaDto criteria)
        {
            var result = new ValidationResultDto();

            var validateExistence = await ValidateExistenceById(criteria);

            if (!string.IsNullOrEmpty(validateExistence.Mensaje))
            {
                result.Mensajes.Add(validateExistence);
            }

            return result;

        }

        public async Task<(ValidationResultDto Validaciones, Comprobante ComprobanteEntity)> ValidateForUpdate(UpdateComprobanteCriteriaDto criteria)
        {
            var validacion = new ValidationResultDto();

            //Valida que el comprobante con id exista
            var result = await ValidateExistence(criteria.Id);

            if (!string.IsNullOrEmpty(result.Validacion.Mensaje))
            {
                validacion.Mensajes.Add(result.Validacion);
            }

            return (validacion, result);
        }

    

        private async Task<(ValidationConditionDto Validacion, Comprobante ComprobanteEntity)> ValidateExistence(CreateComprobanteCriteriaDto criteria)

            {
                var validacion = new ValidationConditionDto();

                var comprobanteEntity = await _comprobanteRepository.GetAll().FirstOrDefaultAsync(c => c.Id == criteria.Id);

                if (comprobanteEntity != null)
                {

                    validacion.Mensaje = "El Comprobante Existe";

                    return (validacion, null);
                }

                return (validacion, comprobanteEntity);
            }

        private async Task<(ValidationConditionDto, Comprobante ComprobanteEntity)> ValidateExistenceById(long Id)
             { 
                var result = new ValidationConditionDto();

                var comprobanteEntity = await _comprobanteRepository.GetAll().FirstOrDefaultAsync(c => c.Id == Id);

                if (comprobanteEntity == null)
                {

                    result.Mensaje = "El Comprobante No Existe";

                    return (result, null);
                }

            return (result,comprobanteEntity);
        }
        
    }
} 




