using Demos.Patterns.Asynchronous.Demos.Breakfast.Bases;
using Demos.Patterns.Asynchronous.Demos.Breakfast.Entities;
using Demos.Patterns.Asynchronous.Demos.Contracts;

namespace Demos.Patterns.Asynchronous.Demos.Breakfast;

public class CookBreakfastAsync40
: BreakfastBase, IAsyncDemo
{
    public string Description => "Returning Tasks and awaiting them.";

    public string Summary => "The preceding code won't get your breakfast ready any faster. The tasks are all awaited as soon as they are started. Next, you can move the await statements for the bacon and eggs to the end of the method, before serving breakfast";

    public short Ordinal => 40;

    public async Task RunDemoAsync()
    {
        Coffee cup = PourCoffee();
        Console.WriteLine("Coffee is ready");

        Task<Egg> eggsTask = FryEggsAsync(2);
        Egg eggs = await eggsTask;
        Console.WriteLine("Eggs are ready");

        Task<Bacon> baconTask = FryBaconAsync(3);
        Bacon bacon = await baconTask;
        Console.WriteLine("Bacon is ready");

        Task<Toast> toastTask = ToastBreadAsync(2);
        Toast toast = await toastTask;
        ApplyButter(toast);
        ApplyJam(toast);
        Console.WriteLine("Toast is ready");

        Juice oj = PourOJ();
        Console.WriteLine("Oj is ready");
        Console.WriteLine("Breakfast is ready!");
    }
}
