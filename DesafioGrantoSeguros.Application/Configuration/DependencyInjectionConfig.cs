using DesafioGrantoSeguros.Domain.Interfaces.Repositories;
using DesafioGrantoSeguros.Domain.Interfaces.Services;
using DesafioGrantoSeguros.Domain.Services;
using DesafioGrantoSeguros.Infrastructure.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioGrantoSeguros.Application.Configuration
{
    public static class DependecyInjectionConfig
    {
        public static void AddDependecyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IVendedorRepository, VendedorRepository>();
            services.AddScoped<IVendedorService, VendedorService>();

            services.AddScoped<IOportunidadeRepository, OportunidadeRepository>();
            services.AddScoped<IOportunidadeService, OportunidadeService>();
        }
    }
}
