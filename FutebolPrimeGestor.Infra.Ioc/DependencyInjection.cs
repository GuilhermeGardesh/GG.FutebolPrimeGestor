using FutebolPrimeGestor.Domain.Entities;
using FutebolPrimeGestor.Domain.Interfaces;
using FutebolPrimeGestor.Infra.Data.Context;
using FutebolPrimeGestor.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FutebolPrimeGestor.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FutebolPrimeGestorDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), x => x.MigrationsAssembly(typeof(FutebolPrimeGestorDbContext).Assembly.FullName));
            });

            //REPOSITORIES
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IQuadraRepository, QuadraRepository>();
            services.AddScoped<IAluguelDeQuadraRepository, AluguelDeQuadraRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            //SERVICES
            
            return services;
        }
    }
}
