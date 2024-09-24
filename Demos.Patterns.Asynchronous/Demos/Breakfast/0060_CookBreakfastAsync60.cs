using Demos.Patterns.Asynchronous.Demos.Breakfast.Bases;
using Demos.Patterns.Asynchronous.Demos.Breakfast.Entities;
using Demos.Patterns.Asynchronous.Demos.Contracts;

namespace Demos.Patterns.Asynchronous.Demos.Breakfast;

public class CookBreakfastAsync60
: BreakfastBase, IAsyncDemo
{
    public string Description => string.Empty;

    public string Summary => string.Empty;

    public short Ordinal => 60;

    public async Task RunDemoAsync()
    {
        Coffee cup = PourCoffee();
        Console.WriteLine("Coffee is ready");

        Task<Egg> eggsTask = FryEggsAsync(2);
        Task<Bacon> baconTask = FryBaconWithEggsAsync(3, eggsTask); // has to wait, since it requires a result from eggsTask
        Task<Toast> toastTask = ToastBreadAsync(2);

        Toast toast = await toastTask;
        ApplyButter(toast);
        ApplyJam(toast);
        Console.WriteLine("Toast is ready");
        Juice oj = PourOJ();
        Console.WriteLine("Oj is ready");

        Egg eggs = await eggsTask;
        Console.WriteLine("Eggs are ready");
        Bacon bacon = await baconTask;
        Console.WriteLine("Bacon is ready");

        Console.WriteLine("Breakfast is ready!");
    }
}