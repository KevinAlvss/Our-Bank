using BuberDinner.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;
using OurBank.Application.Common.Authentication;
using OurBank.Application.Common.Interfaces;
using OurBank.Infrastructure.Repositories;

namespace BuberDinner.Infrastructure;

public static class DependencyInjection {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IUserRepository, UserRepository>();
                
        return services;
    }
}