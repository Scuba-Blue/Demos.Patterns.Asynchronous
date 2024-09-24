using Demos.Patterns.Asynchronous.Abstractions.Contracts;
using Tests.Demos.Patterns.Asynchronous.Bases;

namespace Tests.Demos.Patterns.Asynchronous.Injections;

public class RepositoryInjectionTests
: TestBase
{
    [Fact]
    public void Injection_Repository_NumberOfInstances()
    {
        AssertCountOfServices<IRepository>(1);
    }
}
