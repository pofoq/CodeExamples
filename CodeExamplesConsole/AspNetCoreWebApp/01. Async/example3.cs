using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeExamplesConsole.AspNetCoreWebApp.lesson1
{
    internal static class example3
    {
        internal static void Start()
        {
            var tasks = Task.WhenAll(MakePizza(PizzaKind.Chili), MakePizza(PizzaKind.Margarita), MakePizza(PizzaKind.Mazarella));
            var result = tasks.Result;
            foreach (var res in result)
            {
                Console.WriteLine(res.Kind);
            }

            GoToWork();
        }

        private static void GoToWork()
        {
            Console.WriteLine();
            Console.WriteLine("Go to Work");
        }

        private static async Task MakeCoffe()
        {
            Console.WriteLine($"Coffe. Warm water");
            await WorkEmulation(3000);
            Console.WriteLine($"Coffe. Make coffee");
            await WorkEmulation(2000);
            Console.WriteLine($"Coffe. It's too hot!!!");
            await WorkEmulation(1000);
            Console.WriteLine($"Coffe. Done!");
        }

        private static async Task<Pizza> MakePizza(PizzaKind kind)
        {
            Console.WriteLine($"Pizza. Start making a pizza");
            await WorkEmulation(4000);
            Console.WriteLine($"Pizza. Pizza is Ready!");
            return new Pizza(kind);
        }

        private static async Task TakeShower()
        {
            Console.WriteLine($"Shower. Start taking a shower");
            await WorkEmulation(6000);
            Console.WriteLine($"Shower. Finish taking a shower!");
        }

        internal class Pizza
        {
            public Pizza(PizzaKind kind)
            {
                Kind = kind;
            }

            public PizzaKind Kind { get; }
        }

        public enum PizzaKind
        {
            Margarita,
            Mazarella,
            Chili
        }

        private static Task WorkEmulation(int milliseconds)
        {
            //return new Task(() => Thread.Sleep(milliseconds));
            return Task.Delay(milliseconds);
        }
    }
}
