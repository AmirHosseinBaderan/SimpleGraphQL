using DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Services.Injection;

public static class ProgramInjections
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {

        //Db Context
        services.AddDbContext<GraphContext>(options => options.UseSqlServer(configuration.GetConnectionString("GraphDb")));

        //Db Services

        services.AddGraphQLServer();



        return services;
    }
}