using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {// Creating Scoped interface for ease of testing
            services.AddScoped<ITokenService, TokenService>();

            services.AddDbContext<DataContext>(Options =>
            {
                Options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}