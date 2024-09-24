using Demos.Patterns.Asynchronous.Abstractions.Contracts;
using Demos.Patterns.Asynchronous.Abstractions.Entities.Sales;

namespace Demos.Patterns.Asynchronous.Abstractions.Repositories;

public interface IImportersRepository
: DbContext, IRepository
{
    IList<Customer> LoadCustomersAndOrdersToList();

    Task<IList<Customer>> LoadCustomersAndOrdersToListAsync();

    IEnumerable<Customer> LoadCustomersAndOrdersEnumerableSync();

    Task<IEnumerable<Customer>> LoadCustomersAndOrdersEnumerableAsync();
}