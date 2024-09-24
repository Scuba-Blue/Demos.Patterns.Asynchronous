namespace Demos.Patterns.Asynchronous.Demos.Contracts;

/// <summary>
/// contract for synchronous demos
/// </summary>
public interface ISyncDemo
: IDemo
{
    /// <summary>
    /// run the demo synchronously
    /// </summary>
    void RunDemoSync();
}