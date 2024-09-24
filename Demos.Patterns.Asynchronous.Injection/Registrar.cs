using Bytz.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Demos.Patterns.Asynchronous.Injection;

public static class Registrar
{
    public static IServiceCollection RegisterServices
    (
        this IServiceCollection services
    )
    {
        return services.Register<ApplicationRegistry>();
    }
}