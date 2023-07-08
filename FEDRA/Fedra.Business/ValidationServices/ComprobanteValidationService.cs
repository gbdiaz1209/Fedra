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
        private readonly IComprobanteRepository _comprobanteRepository; //inyectar la dependencia del repositorio, porque tenemos que validar que existe.
        public ComprobanteValidationService(IComprobanteRepository comprobanteRepository)
        {
            _comprobanteRepository = comprobanteRepository;
        }
        public async Task<(ValidationResultDto Validaciones, Comprobante ComprobanteEntity)> ValidateForUpdate(UpdateComprobanteCriteriaDto criteria)
        {
            var validaciones = new ValidationResultDto();
            var result = await ValidateExistenceById(criteria.Id);//Valida que el comprobante con id exista
            if (!string.IsNullOrEmpty(result.Validacion.Mensaje))
            {
                validaciones.Mensajes.Add(result.Validacion);
                return (validaciones,null);
            }
            return (validaciones, result.ComprobanteEntity );
        }

        public async Task<(ValidationResultDto Validaciones, Comprobante ComprobanteEntity)> ValidateForUpdateEstado(UpdateComprobanteEstadoCriteriaDto criteria)
        {
            var validaciones = new ValidationResultDto();
            var result = await ValidateExistenceById(criteria.Id);//Valida que el comprobante con id exista
            if (!string.IsNullOrEmpty(result.Validacion.Mensaje))
            {
                validaciones.Mensajes.Add(result.Validacion);
                return (validaciones, null);
            }
            return (validaciones, result.ComprobanteEntity);
        }

        private async Task<(ValidationConditionDto Validacion, Comprobante ComprobanteEntity)> ValidateExistenceById(long Id)
             { 
                var validacion = new ValidationConditionDto();
                var comprobanteEntity = await _comprobanteRepository.GetAll().FirstOrDefaultAsync(c => c.Id == Id);
                if (comprobanteEntity == null)
                {
                 validacion.Mensaje = "El Comprobante No Existe";
                 return (validacion, null);
                }
                return (validacion,comprobanteEntity);
        }
   }
} 




