using Bytz.Extensions.DependencyInjection;
using Bytz.Extensions.DependencyInjection.Registration;
using Microsoft.Extensions.DependencyInjection;

namespace Tests.Demos.Patterns.Asynchronous.Common.Bases;

public abstract class TestBase<TRegistry>
where TRegistry : RegistryBase, new()
{
    public IServiceCollection ServiceCollection =>
        new ServiceCollection()
        .Register<TRegistry>();

    public IServiceProvider ServiceProvider =>
        new ServiceCollection()
        .Register<TRegistry>()
        .BuildServiceProvider();
}
