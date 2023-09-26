using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace wTrack.Application;
public static class DependecyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(DependecyInjection).Assembly;

        services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssembly(assembly));

        services.AddValidatorsFromAssembly(assembly);


        return services;
    }
}
