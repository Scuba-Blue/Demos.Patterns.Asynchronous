using Demos.Patterns.Asynchronous.Abstractions.Entities.Sales;
using Demos.Patterns.Asynchronous.Abstractions.Repositories;
using Demos.Patterns.Asynchronous.Bases;
using Demos.Patterns.Asynchronous.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Demos.Patterns.Asynchronous.Repositories;

public class ImportersRepository
(
    ImportersContext context
)
: RepositoryBase<ImportersContext>(context), IImportersRepository
{
    public async Task<IEnumerable<Customer>> LoadCustomersAndOrdersEnumerableAsync()
    {
        return await Task.FromResult(customersQuery(Context));
    }

    public IEnumerable<Customer> LoadCustomersAndOrdersEnumerableSync()
    {
        return customersQuery(Context);
    }

    public IList<Customer> LoadCustomersAndOrdersToList()
    {
        return customersQuery(Context).ToList();
    }

    public async Task<IList<Customer>> LoadCustomersAndOrdersToListAsync()
    {
        return await customersQuery(Context).ToListAsync();
    }
}