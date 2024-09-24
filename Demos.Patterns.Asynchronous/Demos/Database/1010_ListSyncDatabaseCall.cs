using Demos.Patterns.Asynchronous.Abstractions.Entities.Sales;
using Demos.Patterns.Asynchronous.Abstractions.Repositories;
using Demos.Patterns.Asynchronous.Demos.Contracts;

namespace Demos.Patterns.Asynchronous.Demos.Database;

public class ListSyncDatabaseCall1010
(
    IImportersRepository _importersRepository
)
: ISyncDemo
{
    public string Description => "Synchronous database call for loading customers and orders.";

    public string Summary => "End of the synchronous database call.";

    public short Ordinal => 1010;

    public void RunDemoSync()
    {
        IList<Customer> results = _importersRepository.LoadCustomersAndOrdersToList();

        foreach (Customer result in results)    // forces an expectd element, since something needs to be done
        {
            //   do something, this will require each customer a source instance to be manifested
        }
    }
}
