using Demos.Patterns.Asynchronous.Abstractions.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Demos.Patterns.Asynchronous.Contexts;

public class ImportersContext
(
    IConfiguration configuration
)
: DbContext
{
    private readonly IConfiguration _configuration = configuration;

    protected override void OnConfiguring
    (
        DbContextOptionsBuilder optionsBuilder
    )
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("WideWorldImporters"));
        }
    }

    protected override void OnModelCreating
    (
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<Customer>(e =>
        {
            e.ToTable("Customers", "Sales");
        });

        modelBuilder.Entity<Invoice>(e =>
        {
            e.ToTable("Invoices", "Sales");
        });

        modelBuilder.Entity<InvoiceLine>(e =>
        {
            e.ToTable("InvoiceLines", "Sales");
        });

        modelBuilder.Entity<Order>(e =>
        {
            e.ToTable("Orders", "Sales");
        });

        modelBuilder.Entity<OrderLine>(e =>
        {
            e.ToTable("OrderLines", "Sales");
        });
    }
}
