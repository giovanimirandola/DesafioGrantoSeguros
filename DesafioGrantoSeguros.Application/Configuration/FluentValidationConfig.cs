using DesafioGrantoSeguros.Domain.Interfaces.Repositories;
using DesafioGrantoSeguros.Domain.Interfaces.Services;
using DesafioGrantoSeguros.Domain.Services;
using DesafioGrantoSeguros.Domain.Validator;
using DesafioGrantoSeguros.Infrastructure.DataAccess.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioGrantoSeguros.Application.Configuration
{
    public static class FluentValidationConfig
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {
            services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<VendedorValidator>());
            services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<OportunidadeValidator>());
        }
    }
}
