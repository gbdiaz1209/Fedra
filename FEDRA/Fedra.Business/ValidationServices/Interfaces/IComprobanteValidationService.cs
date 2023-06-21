﻿using Fedra.Data.Entities;
using Fedra.Dto.Comprobante;
using Fedra.Dto.Validation;

namespace Fedra.Business.ValidationServices.Interfaces
{
    public interface IComprobanteValidationService
    {
       Task<ValidationResultDto> ValidateForCreate(CreateComprobanteCriteriaDto criteria);
       Task<(ValidationResultDto Validaciones, Comprobante ComprobanteEntity)> ValidateForUpdate(UpdateComprobanteCriteriaDto criteria);
     
       Task<ValidationConditionDto> ValidarExistencia(CreateComprobanteCriteriaDto criteria);
       Task<(ValidationConditionDto Validacion, Comprobante ComprobanteEntity)> ValidarExistenciaPorId(long Id);


    }
}
