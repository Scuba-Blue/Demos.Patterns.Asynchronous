using Demos.Patterns.Asynchronous.Abstractions.Entities.Sales;
using Demos.Patterns.Asynchronous.Contexts;
using Demos.Patterns.Asynchronous.Injection;
using Tests.Common.Bases;

namespace Tests.Demos.Patterns.Asynchronous.Entity;

public class EntityRelationshipTests
: ContextTestBase<ApplicationRegistry, ImportersContext>
{
    [Fact]
    public void Entity_Relationship_Customer_To_Order()
    {
        AssertOneToMany<Customer, Order>(s => s.OrderItems);
    }

    [Fact]
    public void Entity_Relationship_Order_To_Customer()
    {
        AssertManyToOne<Order, Customer>(s => s.CustomerItem);
    }

    [Fact]
    public void Entity_Relationship_Customer_To_Invoice()
    {
        AssertOneToMany<Customer, Invoice>(s => s.InvoiceItems);
    }

    [Fact]
    public void Entity_Relationship_Invoice_To_Customer()
    {
        AssertManyToOne<Invoice, Customer>(s => s.CustomerItem);
    }
}
