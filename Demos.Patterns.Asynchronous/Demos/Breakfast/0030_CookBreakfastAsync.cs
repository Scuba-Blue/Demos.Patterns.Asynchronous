using Demos.Patterns.Asynchronous.Demos.Breakfast.Bases;
using Demos.Patterns.Asynchronous.Demos.Breakfast.Entities;
using Demos.Patterns.Asynchronous.Demos.Contracts;

namespace Demos.Patterns.Asynchronous.Demos.Breakfast
{
    public class CookBreakfastAsync30
    : BreakfastBase, IAsyncDemo
    {
        public short Ordinal => 30;

        public string Description => "Asyncrhonous code behaving badly.";

        public string Summary => "Now, the thread working on the breakfast isn't blocked while awaiting any started task that hasn't yet finished. For some applications, this change is all that's needed. A GUI application still responds to the user with just this change. However, for this scenario, you want more. You don't want each of the component tasks to be executed sequentially. It's better to start each of the component tasks before awaiting the previous task's completion.";

        public async Task RunDemoAsync()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("Coffee is ready");


            //  since each task is awaited and
            //  the result of the task is requred
            //  by the calling-code, there is no
            //  real difference between this code
            //  and the sync
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
}
