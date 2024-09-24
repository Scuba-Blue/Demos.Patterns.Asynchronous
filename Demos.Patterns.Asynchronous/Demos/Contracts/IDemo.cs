namespace Demos.Patterns.Asynchronous.Demos.Contracts;

/// <summary>
/// base interface for di
/// </summary>
public interface IDemo
{
    string Description { get; }

    string Summary { get; }

    short Ordinal { get; }
}