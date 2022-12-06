using Microsoft.Extensions.DependencyInjection;

namespace Services.Injection;

public static class ProgramInjections
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddGraphQLServer();

        return services;
    }
}