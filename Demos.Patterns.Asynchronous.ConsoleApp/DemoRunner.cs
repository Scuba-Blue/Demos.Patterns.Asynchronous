using Demos.Patterns.Asynchronous.Demos.Contracts;
using Demos.Patterns.Asynchronous.Injection;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Demos.Patterns.Asynchronous.ConsoleApp;

internal static class DemoRunner
{
    private static readonly IServiceProvider _serviceProvider;

    static DemoRunner()
    {
        _serviceProvider =
            new ServiceCollection()
            .RegisterServices()
            .BuildServiceProvider();
    }

    public static TimeSpan RunSyncDemo<TSyncDemo>() 
    where TSyncDemo 
    : ISyncDemo
    {
        TSyncDemo demo = _serviceProvider.GetRequiredService<TSyncDemo>();

        DisplayDemoAndExplanation(demo);

        TimeSpan timeSpan = TimeActionSync(() => demo.RunDemoSync());

        DisplayElapsedTimeAndSummary(demo, timeSpan);

        return timeSpan;
    }

    private static void DisplayDemoAndExplanation<TDemo>
    (
        TDemo demo
    ) 
    where TDemo : IDemo
    {
        Console.Clear();
        Console.WriteLine($"Ordinal: {demo.Ordinal}\nDemo Name: {demo.GetType().Name}\n{demo.Description}");
        Console.WriteLine("\n");
    }

    private static TimeSpan TimeActionSync
    (
        Action action
    )
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        action();

        stopwatch.Stop();

        return stopwatch.Elapsed;
    }

    private static void DisplayElapsedTimeAndSummary<TSyncDemo>
    (
        TSyncDemo demo, 
        TimeSpan timeSpan
    ) 
    where TSyncDemo : IDemo
    {
        Console.WriteLine("\n");
        Console.WriteLine($"Elapsed Time: {timeSpan}\n");
        Console.WriteLine($"{demo.Summary}");
    }

    public static async Task<TimeSpan> RunAsyncDemo<TAsyncDemo>()
    where TAsyncDemo : IAsyncDemo
    {
        TAsyncDemo demo = _serviceProvider.GetRequiredService<TAsyncDemo>();

        DisplayDemoAndExplanation(demo);

        TimeSpan timeSpan = await TimeActionAsync(() => demo.RunDemoAsync());

        DisplayElapsedTimeAndSummary(demo, timeSpan);

        return timeSpan;
    }

    private static async Task<TimeSpan> TimeActionAsync
    (
        //  has to be a func<task> sync async version of "void" is "task"
        //  and only functions return values, not actions and a func<task>
        //  can be awaited in an async function.
        Func<Task> function 
    )
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        await function();

        stopwatch.Stop();

        return stopwatch.Elapsed;
    }
}