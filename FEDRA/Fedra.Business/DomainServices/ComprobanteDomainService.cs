using Fedra.Business.DomainServices.Interfaces;
using Fedra.Business.Extensions;
using Fedra.Business.ValidationServices.Interfaces;
using Fedra.Data.Repositories.Interfaces;
using Fedra.Dto.Comprobante;
using Fedra.Dto.Validation;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Business.DomainServices
{
    public class ComprobanteDomainService : IComprobanteDomainService
    {
        private readonly IComprobanteRepository _comprobanteRepository;
        private readonly IComprobanteValidationService _comprobanteValidationService;

        public ComprobanteDomainService(IComprobanteRepository comprobanteRepository, IComprobanteValidationService comprobanteValidationService)
        {
            _comprobanteRepository = comprobanteRepository;
            _comprobanteValidationService = comprobanteValidationService;
        }
        public async Task<ComprobanteDto> CreateComprobanteAsync(CreateComprobanteCriteriaDto criteria)
        {        
            var comprobanteEntity = criteria.ConvertDtoToEntity(); //Mapear criteria DTO a la entidad
            _comprobanteRepository.Add(comprobanteEntity); // usar el comprobante repositorio para guardar la fila en la tabla.
            await _comprobanteRepository.SaveChangesAsync();
            var dto = comprobanteEntity.ConvertEntityToDto(); //mapear/convertir la entidad que me devuelve EF al DTO que necesito mandarle al la capa superior
            return dto;  //retornar el DTO
        }
        public async Task<(ValidationResultDto Validaciones, ComprobanteDto Comprobante)> UpdateComprobanteAsync(UpdateComprobanteCriteriaDto criteria)
        {
            var result = await _comprobanteValidationService.ValidateForUpdate(criteria); // validar el criteria - que exista
            if (result.Validaciones.Mensajes.Any())
            {
                return (result.Validaciones, null); 
            }
            var entity = result.ComprobanteEntity;

            entity.Consecutivo = criteria.Consecutivo;
            entity.Descripcion = criteria.Descripcion;
            entity.Valor = criteria.Valor;
            entity.TerceroId = criteria.TerceroId;
            entity.DocumentoId = criteria.DocumentoId;
            entity.FormaPagoId = criteria.FormaPagoId;
            entity.CategoriaComprobanteId = criteria.CategoriasComprobanteId;
            entity.ReferenciaPago = criteria.ReferenciaPago;
            entity.TipoConfiguracionDocumentoId = criteria.TipoConfiguracionDocumentoId;
            entity.EmpresaId = criteria.EmpresaId;
            entity.FechaModificacion = DateTime.Now;
            entity.Modificadopor = criteria.ModificadoPor; 
            entity.FechaCreacion = DateTime.Now;
          
            //ya tengo la entidad
            _comprobanteRepository.Update(entity); // usar el repositorio y le paso la entidad
            await _comprobanteRepository.SaveChangesAsync();// guarda los cambios
            var dto = entity.ConvertEntityToDto(); // cambio la entidad a dto
            return (new ValidationResultDto(), dto);
        }
        public async Task<(ValidationResultDto Validaciones, ComprobanteDto Comprobante)> UpdateComprobanteEstadoAsync(UpdateComprobanteEstadoCriteriaDto criteria)
        {
            var result = await _comprobanteValidationService.ValidateForUpdateEstado(criteria); // validar el criteria - que exista
            if (result.Validaciones.Mensajes.Any())
            {
                return (result.Validaciones, null);
            }
            var entity = result.ComprobanteEntity;

            entity.Estado = criteria.Estado;           
            entity.FechaModificacion = DateTime.Now;
            entity.Modificadopor = criteria.ModificadoPor;

            //ya tengo la entidad
            _comprobanteRepository.Update(entity); // usar el repositorio y le paso la entidad
            await _comprobanteRepository.SaveChangesAsync();// guarda los cambios
            var dto = entity.ConvertEntityToDto(); // cambio la entidad a dto
            return (new ValidationResultDto(), dto);
        }


        public async Task<List<ComprobanteDto>> GetComprobanteByIdAsync(long id)
        {
            var comprobantesBuscados = await _comprobanteRepository
                                                           .GetAll(false)
                                                           .Where(cb => cb.Id == id)
                                                           .ToListAsync();
         
            var comprobantesComoDto = comprobantesBuscados.Select(cmb => cmb.ConvertEntityToDto()).ToList();//seleccionar comprobante por comprobante y convertirlo a dto
            return comprobantesComoDto;
        }
    }
}