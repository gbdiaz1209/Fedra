using Fedra.Business.Constants;
using Fedra.Data.Entities;
using Fedra.Dto.Departamento;
using Fedra.Dto.Municipio;
using Fedra.Dto.Tercero;
using Fedra.Dto.TipoIdentificacion;

namespace Fedra.Business.Extensions
{
    // las extenciones deben ser de clases estaticas
    public static class TerceroExtensions
    {
        //todas las clases estaticas deben tener miembros estaticos 
        // los metodos extensivos o extensions method los parametros empiezan siempre con la palabra this.
        //los nombres de los parametros siempre empiezxan en minuscula
        public static Tercero ConvertDtoToEntity(this CreateTerceroCriteriaDto criteria)
        {
            if (criteria == null)
            {
                return new Tercero();
            }

            //los nombres de las variables siempre empiezan en minuscula
            var terceroEntity = new Tercero
            {
                EmpresaId = criteria.EmpresaId,
                TipoIdentificacionId = criteria.TipoIdentificacionId,
                Numero = criteria.Numero,
                Tipo = criteria.Tipo,
                Nombre = criteria.Nombre,
                Direccion = criteria.Direccion,
                Celular = criteria.Celular,
                Telefono = criteria.Telefono,
                Email = criteria.Email,
                DepartamentoId = criteria.DepartamentoId,
                MunicipioId = criteria.MunicipioId,
                Calificacion = criteria.Calificacion,
                Observaciones = criteria.Observaciones,
                CreadoPor = criteria.CreadoPor,
                FechaCreacion = DateTime.Now,
                ModificadoPor = criteria.ModificadoPor,
                FechaModificacion = DateTime.Now,
                Estado = (int)EstadoActivacion.Activo
            };

            return terceroEntity;
        }

        public static TerceroDto ConvertEntityToDto(this Tercero entity)
        {
            if (entity == null)
            {
                return new TerceroDto();
            }

            //los nombres de las variables siempre empiezan en minuscula
            var terceroDto = new TerceroDto
            {
                Id = entity.Id,
                Estado = entity.Estado,
                TipoIdentificacion = new TipoIdentificacionDto
                {
                    Id = entity.TipoIdentificacion != null ? entity.TipoIdentificacion.Id : 0,
                    Nombre = entity.TipoIdentificacion != null ? entity.TipoIdentificacion.Descripcion : string.Empty
                },
                Numero = entity.Numero,
                Tipo = entity.Tipo,
                Nombre = entity.Nombre,
                Direccion = entity.Direccion,
                Celular = entity.Celular,
                Telefono = entity.Telefono,
                Email = entity.Email,
                Departamento = new DepartamentoDto
                {
                    Id = entity.Departamento != null ? entity.Departamento.Id : 0,
                    Nombre = entity.Departamento != null ? entity.Departamento.Descripcion : string.Empty
                },
                Municipio = new MunicipioDto
                {
                    Id = entity.Municipio != null ? entity.Municipio.Id : 0,
                    Nombre = entity.Municipio != null ? entity.Municipio.Descripcion : string.Empty
                },
                Calificacion = entity.Calificacion,
                Observaciones = entity.Observaciones,
                CreadoPor = entity.CreadoPor,
                FechaCreacion = entity.FechaCreacion,
                ModificadoPor = entity.ModificadoPor,
                FechaModificacion = entity.FechaModificacion
            };

            return terceroDto;
        }
    }

}
