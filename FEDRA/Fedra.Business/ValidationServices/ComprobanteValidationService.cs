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
        private readonly IComprobanteRepository _comprobanteRepository;

        public ComprobanteValidationService(IComprobanteRepository comprobanteRepository)
        {
            _comprobanteRepository = comprobanteRepository;
        }

        public async Task<ValidationResultDto> ValidateForCreate(CreateComprobanteCriteriaDto criteria)
        {
            var result = new ValidationResultDto();

            //Valida que el comprobante con el numero de id

            var validarExistencia = await ValidarExistencia(criteria);

            if (!string.IsNullOrEmpty(validarExistencia.Mensaje))
            {
                result.Mensajes.Add(validarExistencia);
            }

            return result;
        }

        public async Task<(ValidationResultDto Validaciones, Comprobante ComprobanteEntity)> ValidateForUpdate(UpdateComprobanteCriteriaDto criteria)

        {
            var validationResult = new ValidationResultDto();


            var result = await ValidarExistenciaPorId(criteria.Id);  //Valida que el comprobante con id exista

            if (!string.IsNullOrEmpty(result.Validacion.Mensaje))
            {
                validationResult.Mensajes.Add(result.Validacion);
            }

            return (validationResult, result.ComprobanteEntity);
        }


        private async Task<ValidationConditionDto> ValidarExistencia(CreateComprobanteCriteriaDto criteria)
        {
            var result = new ValidationConditionDto();

            var comprobanteEntity = await _comprobanteRepository.GetAll().FirstOrDefaultAsync(t => t.Id == criteria.Id);

            if (comprobanteEntity != null)
            {

                result.Mensaje = "El Comprobante ya existe";

                return result;
            }

            return result;
        }

        private async Task<(ValidationConditionDto Validacion, Comprobante ComprobanteEntity)> ValidarExistenciaPorId(long Id)

        {
            var result = new ValidationConditionDto();

            var comprobanteEntity = await _comprobanteRepository.GetAll().FirstOrDefaultAsync(t => t.Id == Id);

            if (comprobanteEntity == null)
            {
                result.Mensaje = "El Comprobante No existe";

                return (result, null);
            }

            return (result, comprobanteEntity);
        }

    }

}