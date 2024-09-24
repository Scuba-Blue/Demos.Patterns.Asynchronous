using Bytz.Extensions.DependencyInjection;
using Bytz.Extensions.DependencyInjection.Registration;
using Demos.Patterns.Asynchronous.Abstractions.Contracts;
using Demos.Patterns.Asynchronous.Demos.Bases;
using Demos.Patterns.Asynchronous.Demos.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Demos.Patterns.Asynchronous.Injection;

public class ApplicationRegistry
: RegistryBase
{
    protected override void OnRegister
    (
        IServiceCollection services
    )
    {
        OnConfigure(services);

        services.Register
        (r => r
            .InAssemblyOf<AssemblyMarker>()
            .Implementing<IRepository>()
            .AllInterfaces()
            .AsTransient()
            .ConfigureOrThrow()
        );

        services.Register
        (r => r
            .InAssemblyOf<AssemblyMarker>()
            .BasedOn<DbContext>()
            .WithoutInterfaces()
            .AsScoped()
            .ConfigureOrThrow()
        );

        services.Register
        (r => r
            .InAssemblyOf<AssemblyMarker>()
            .BasedOn<DemoBase>()
            .WithoutInterfaces()
            .AsSingleton()
            .ConfigureOrThrow()
        );

        services.Register
        (r => r
            .InAssemblyOf<AssemblyMarker>()
            .Implementing<IService>()
            .AllInterfaces()
            .AsTransient()
            .Configure()
        );

        services.Register
        (r => r
            .InAssemblyOf<AssemblyMarker>()
            .BasedOn<DemoBase>()
            .WithoutInterfaces()
            .AsSingleton()
            .ConfigureOrThrow()
        );

        services.Register
        (r => r
            .InAssemblyOf<AssemblyMarker>()
            .Implementing<IDemo>()
            .AllInterfaces()
            .AsTransient()
            .ConfigureOrThrow()
        );
    }

    public static void OnConfigure(IServiceCollection services)
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false)
            .Build();

        services.AddSingleton(configuration);
    }
}