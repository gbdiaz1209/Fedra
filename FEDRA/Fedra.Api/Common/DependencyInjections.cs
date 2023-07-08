using Fedra.Business.DomainServices;
using Fedra.Business.DomainServices.Interfaces;
using Fedra.Business.ValidationServices;
using Fedra.Business.ValidationServices.Interfaces;
using Fedra.Data.Repositories;
using Fedra.Data.Repositories.Interfaces;

namespace Fedra.Api.Common
{
    public class DependencyInjections
    {
        public WebApplicationBuilder ConfigAppDependencies(WebApplicationBuilder builder)
        {
            ConfigRepositoriesDependencies(builder);

            ConfigValidationServicesDependencies(builder);

            ConfigDomainServicesDependencies(builder);

            return builder;
        }

        public void ConfigRepositoriesDependencies(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ITerceroRepository, TerceroRepository>();
            builder.Services.AddTransient<IDepartamentoRepository, DepartamentoRepository>();
            builder.Services.AddTransient<IExencionRepository, ExencionRepository>();
            builder.Services.AddTransient<IImpuestoRepository, ImpuestoRepository>();
            builder.Services.AddTransient<IMunicipioRepository, MunicipioRepository>();            
            builder.Services.AddTransient<ITipoIdentificacionRepository, TipoIdentificacionRepository>();
            builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
            builder.Services.AddTransient<IComprobanteRepository, ComprobanteRepository>();
        }

        public void ConfigValidationServicesDependencies(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ITerceroValidationService, TerceroValidationService>();
            builder.Services.AddTransient<IProductoValidationService, ProductoValidationService>();
            builder.Services.AddTransient<IComprobanteValidationService, ComprobanteValidationService>();
        }

        public void ConfigDomainServicesDependencies(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ITerceroDomainService, TerceroDomainService>();
            builder.Services.AddTransient<IProductoDomainService, ProductoDomainService>();
            builder.Services.AddTransient<IComprobanteDomainService, ComprobanteDomainService>();
        }
    }
}
