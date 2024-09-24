using Demos.Patterns.Asynchronous.Abstractions.Entities.Sales;
using Demos.Patterns.Asynchronous.Abstractions.Repositories;
using Demos.Patterns.Asynchronous.Demos.Contracts;

namespace Demos.Patterns.Asynchronous.Demos.Database;

public class ListDatabaseCallAsync1020
(
    IImportersRepository _importersRepository
)
: IAsyncDemo
{
    public string Description => "Asynchronous database call for loading customers and orders.";

    public string Summary => "Takes approximately the same time as the synchronous call since processing of the result is requied.";

    public short Ordinal => 1020;

    public async Task RunDemoAsync()
    {
        IList<Customer> results = await _importersRepository.LoadCustomersAndOrdersToListAsync();

        foreach (Customer result in results) // forces an expectd element, since something needs to be done
        {
            //   do something
        }
    }
}