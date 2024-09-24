using Demos.Patterns.Asynchronous.Abstractions.Entities.Sales;
using Demos.Patterns.Asynchronous.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Demos.Patterns.Asynchronous.Bases;

public abstract class RepositoryBase<TContext>
(
    TContext context
)
where TContext : DbContext
{
    protected readonly TContext Context = context;

    protected readonly Func<DbContext, IQueryable<Customer>> customersQuery =
        c => c
            .Set<Customer>()
            .Include(c => c.OrderItems);
}