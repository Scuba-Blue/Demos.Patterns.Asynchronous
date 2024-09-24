using Bytz.Extensions.DependencyInjection.Registration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tests.Demos.Patterns.Asynchronous.Common.Bases;

namespace Tests.Common.Bases;

public class ContextTestBase<TRegistry, TContext>
: TestBase<TRegistry>
where TRegistry : RegistryBase, new()
where TContext : DbContext
{
    public ContextTestBase()
    {
        Context = this.ServiceProvider.GetService<TContext>();
    }

    protected readonly TContext Context;

    protected void AssertEntity<TEntity>()
    where TEntity : class
    {
        _ = Context.Set<TEntity>().FirstOrDefault();
    }

    protected void AssertOneToMany<TOne, TMany>
    (
        Func<TOne, IEnumerable<TMany>> selector
    )
    where TOne : class
    where TMany : class
    {
        _ = Context.Set<TOne>().Select(selector).FirstOrDefault();
    }

    protected void AssertManyToOne<TMany, TOne>
    (
        Func<TMany, TOne> selector
    )
    where TMany : class
    where TOne : class
    {
        _ = Context.Set<TMany>().Select(selector).FirstOrDefault();
    }
}
