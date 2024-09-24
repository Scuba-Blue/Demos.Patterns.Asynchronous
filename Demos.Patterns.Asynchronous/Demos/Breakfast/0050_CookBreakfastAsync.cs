using Demos.Patterns.Asynchronous.Demos.Breakfast.Bases;
using Demos.Patterns.Asynchronous.Demos.Breakfast.Entities;
using Demos.Patterns.Asynchronous.Demos.Contracts;

namespace Demos.Patterns.Asynchronous.Demos.Breakfast;

public class CookBreakfastAsync50
: BreakfastBase, IAsyncDemo
{
    public string Description => "MS Demonstrated use of async.";

    public string Summary => "The asynchronously prepared breakfast took roughly 20 minutes, this time savings is because some tasks ran concurrently. The preceding code works better. You start all the asynchronous tasks at once. You await each task only when you need the results";

    public short Ordinal => 50;

    public async Task RunDemoAsync()
    {
        Coffee cup = PourCoffee();
        Console.WriteLine("Coffee is ready");

        Task<Egg> eggsTask = FryEggsAsync(2);
        Task<Bacon> baconTask = FryBaconAsync(3);
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
