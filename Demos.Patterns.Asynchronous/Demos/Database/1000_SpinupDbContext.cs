using Demos.Patterns.Asynchronous.Abstractions.Repositories;
using Demos.Patterns.Asynchronous.Bases;
using Demos.Patterns.Asynchronous.Contexts;
using Demos.Patterns.Asynchronous.Demos.Contracts;

namespace Demos.Patterns.Asynchronous.Demos.Database;

public class SpinupDbContext1000
(
    ImportersContext _context
)
: RepositoryBase<ImportersContext>(_context), ISyncDemo
{
    public string Description => "Spin-up EF the database context.";

    public string Summary => "DbContext has been spun-up.";

    public short Ordinal => 1000;

    public void RunDemoSync()
    {
        customersQuery(Context);
    }
}