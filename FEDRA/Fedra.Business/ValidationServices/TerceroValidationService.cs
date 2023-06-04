using Fedra.Data.Entities;
using Fedra.Data.Repositories.Interfaces;
using Fedra.Dto.Tercero;
using Fedra.Dto.Validation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedra.Business.ValidationServices
{
    public class TerceroValidationService
    {
        //inyectar la dependencia del repositorio, porque tenemos que validar que existe.
        
        private ITerceroRepository _terceroRepository;
       
        public TerceroValidationService(ITerceroRepository terceroRepository)
        {
            _terceroRepository = terceroRepository;
        }

        public async Task<ValidationResultDto> ValidateForCreate(CreateTerceroCriteriaDto criteria)
        {
            var result = new ValidationResultDto();

            //Valida que el tercero con el numero de identificacion no exista
            var validarExistencia = await ValidarExistencia(criteria);

            if(!string.IsNullOrEmpty(validarExistencia.Mensaje))
            {
                result.Mensajes.Add(validarExistencia);
            }

            return result;
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
    }
}
