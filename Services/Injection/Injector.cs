using DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Implementation;
using Services.Repository;

namespace Services.Injection;

public static class ProgramInjections
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {

        //Db Context
        services.AddDbContext<GraphContext>(options => options.UseSqlServer(configuration.GetConnectionString("GraphDb")));

        //Db Services
        services.AddTransient<IGroupRepository, GroupRepository>();
        services.AddTransient<IProductRepository, ProductRepository>();

        services.AddGraphQLServer()
            .AddQueryType<Query.Query>()
            .AddProjections()
            .AddFiltering()
            .AddSorting();



        return services;
    }
}