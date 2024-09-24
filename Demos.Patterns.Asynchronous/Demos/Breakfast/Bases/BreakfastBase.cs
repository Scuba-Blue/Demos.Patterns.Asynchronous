using Demos.Patterns.Asynchronous.Demos.Bases;
using Demos.Patterns.Asynchronous.Demos.Breakfast.Entities;

namespace Demos.Patterns.Asynchronous.Demos.Breakfast.Bases;

public class BreakfastBase
: DemoBase
{
    protected static Juice PourOJ()
    {
        Console.WriteLine("Pouring orange juice");
        return new Juice();
    }

    protected static void ApplyJam(Toast toast) =>
        Console.WriteLine("Putting jam on the toast");

    protected static void ApplyButter(Toast toast) =>
        Console.WriteLine("Putting butter on the toast");

    protected static Toast ToastBread
    (
        int slices
    )
    {
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Putting a slice of bread in the toaster");
        }
        Console.WriteLine("Start toasting...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Remove toast from toaster");

        return new Toast();
    }

    protected static Bacon FryBacon
    (
        int slices
    )
    {
        Console.WriteLine($"putting {slices} slices of bacon in the pan");
        Console.WriteLine("cooking first side of bacon...");
        Task.Delay(3000).Wait();
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("flipping a slice of bacon");
        }
        Console.WriteLine("cooking the second side of bacon...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Put bacon on plate");

        return new Bacon();
    }

    protected static Egg FryEggs
    (
        int howMany 
    )
    {
        Console.WriteLine("Warming the egg pan...");
        Task.Delay(3000).Wait();
        Console.WriteLine($"cracking {howMany} eggs");
        Console.WriteLine("cooking the eggs ...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Put eggs on plate");

        return new Egg();
    }

    protected static Coffee PourCoffee()
    {
        Console.WriteLine("Pouring coffee");
        return new Coffee();
    }

    //  async 
    static async Task<Toast> MakeToastWithButterAndJamAsync
    (
        int number
    )
    {
        var toast = await ToastBreadAsync(number);
        ApplyButter(toast);
        ApplyJam(toast);

        return toast;
    }

    protected static async Task<Toast> ToastBreadAsync
    (
        int slices
    )
    {
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Putting a slice of bread in the toaster");
        }
        Console.WriteLine("Start toasting...");
        await Task.Delay(3000);
        Console.WriteLine("Remove toast from toaster");

        return new Toast();
    }

    protected static async Task<Bacon> FryBaconAsync
    (
        int slices
    )
    {
        Console.WriteLine($"putting {slices} slices of bacon in the pan");
        Console.WriteLine("cooking first side of bacon...");
        await Task.Delay(3000);
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("flipping a slice of bacon");
        }
        Console.WriteLine("cooking the second side of bacon...");
        await Task.Delay(3000);
        Console.WriteLine("Put bacon on plate");

        return new Bacon();
    }

    protected static async Task<Egg> FryEggsAsync
    (
        int howMany
    )
    {
        Console.WriteLine("Warming the egg pan...");
        await Task.Delay(3000);
        Console.WriteLine($"cracking {howMany} eggs");
        Console.WriteLine("cooking the eggs ...");
        await Task.Delay(3000);
        Console.WriteLine("Put eggs on plate");

        return new Egg();
    }

    //  dependent asyncs
    protected static async Task<Bacon> FryBaconWithEggsAsync
    (
        int slices,
        Task<Egg> eggs
    )
    {
        Console.WriteLine($"Needed eggs. Count is {await eggs}");

        Console.WriteLine($"putting {slices} slices of bacon in the pan");
        Console.WriteLine("cooking first side of bacon...");
        await Task.Delay(3000);
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("flipping a slice of bacon");
        }
        Console.WriteLine("cooking the second side of bacon...");
        await Task.Delay(3000);
        Console.WriteLine("Put bacon on plate");

        return new Bacon();
    }
}

