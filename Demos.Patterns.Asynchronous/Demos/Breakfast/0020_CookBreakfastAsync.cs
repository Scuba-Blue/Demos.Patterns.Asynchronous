using Demos.Patterns.Asynchronous.Demos.Breakfast.Bases;
using Demos.Patterns.Asynchronous.Demos.Breakfast.Entities;
using Demos.Patterns.Asynchronous.Demos.Contracts;

namespace Demos.Patterns.Asynchronous.Demos.Breakfast;

public class CookBreakfastAsync20
: BreakfastBase, IAsyncDemo
{
    public string Description => "Making the same calls asynchronous.";

    public string Summary => "As you can see, there is no real difference in performance. The code is yet to take advantage of some of the asynchronous key features.";

    public short Ordinal => 20;

    public async Task RunDemoAsync()
    {
        Coffee cup = PourCoffee();
        Console.WriteLine("coffee is ready");

        Egg eggs = await FryEggsAsync(2);
        Console.WriteLine("eggs are ready");

        Bacon bacon = await FryBaconAsync(3);
        Console.WriteLine("bacon is ready");

        Toast toast = await ToastBreadAsync(2);
        ApplyButter(toast);
        ApplyJam(toast);
        Console.WriteLine("toast is ready");

        Juice oj = PourOJ();
        Console.WriteLine("oj is ready");
        Console.WriteLine("Breakfast is ready!");
    }
}
