using Demos.Patterns.Asynchronous.Injection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tests.Demos.Patterns.Asynchronous.Common.Bases;

namespace Tests.Demos.Patterns.Asynchronous.Bases;

public abstract class TestBase
: TestBase<ApplicationRegistry>
{
    protected void AssertCountOfServices<TService>
    (
        int expected
    )
    where TService : class
    {
        IEnumerable<TService> services = ServiceProvider.GetServices<TService>();

        Assert.Equal(expected, services.Count());
    }

    protected void AssertContext<TContext>
    (
        int expected
    )
    where TContext : DbContext
    {
        AssertCountOfServices<TContext>(expected);
    }
}
