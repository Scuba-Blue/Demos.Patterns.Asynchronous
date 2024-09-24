using Demos.Patterns.Asynchronous.Demos.Breakfast.Bases;
using Demos.Patterns.Asynchronous.Demos.Breakfast.Entities;
using Demos.Patterns.Asynchronous.Demos.Contracts;

namespace Demos.Patterns.Asynchronous.Demos.Breakfast;

public class CookBreakfastSync10
: BreakfastBase, ISyncDemo
{
    public short Ordinal => 10;

    public string Description => "Example of traditional, synchronous code.";

    public string Summary => "As you can see, this traditional code is time-intensive.";

    public void RunDemoSync()
    {
        Coffee cup = PourCoffee();
        Console.WriteLine("coffee is ready");

        Egg eggs = FryEggs(2);
        Console.WriteLine("eggs are ready");

        Bacon bacon = FryBacon(3);
        Console.WriteLine("bacon is ready");

        Toast toast = ToastBread(2);
        ApplyButter(toast);
        ApplyJam(toast);
        Console.WriteLine("toast is ready");

        Juice oj = PourOJ();
        Console.WriteLine("oj is ready");
        Console.WriteLine("Breakfast is ready!");
    }
}
