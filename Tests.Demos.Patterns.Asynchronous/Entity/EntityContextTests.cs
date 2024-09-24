using Demos.Patterns.Asynchronous.Abstractions.Entities.Sales;
using Demos.Patterns.Asynchronous.Contexts;
using Demos.Patterns.Asynchronous.Injection;
using Tests.Common.Bases;

namespace Tests.Demos.Patterns.Asynchronous.Entity;

public class EntityContextTests
: ContextTestBase<ApplicationRegistry, ImportersContext>
{
    [Fact]
    public void Entity_Context_Customer()
    {
        AssertEntity<Customer>();
    }

    [Fact]
    public void Entity_Context_Invoice()
    {
        AssertEntity<Invoice>();
    }

    [Fact]
    public void Entity_Context_InvoiceLine()
    {
        AssertEntity<InvoiceLine>();
    }

    [Fact]
    public void Entity_Context_Order()
    {
        AssertEntity<Order>();
    }

    [Fact]
    public void Entity_Context_OrderLine()
    {
        AssertEntity<OrderLine>();
    }
}
