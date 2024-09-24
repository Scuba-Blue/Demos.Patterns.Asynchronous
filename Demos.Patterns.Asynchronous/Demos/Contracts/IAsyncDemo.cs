namespace Demos.Patterns.Asynchronous.Demos.Contracts;

/// <summary>
/// contract for async demos
/// </summary>
public interface IAsyncDemo
: IDemo
{
    /// <summary>
    /// run the demo asynchronously
    /// </summary>
    /// <returns></returns>
    Task RunDemoAsync();
}