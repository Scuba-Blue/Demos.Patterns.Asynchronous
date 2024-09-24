using Demos.Patterns.Asynchronous.Contexts;
using Tests.Demos.Patterns.Asynchronous.Bases;

namespace Tests.Demos.Patterns.Asynchronous.Injections;

public class ContextInjectionTests
: TestBase
{
    [Fact]
    public void Injection_Context_NumberOfInstances()
    {
        var descriptors = ServiceCollection;

        AssertContext<ImportersContext>(1);
    }
}