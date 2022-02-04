using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeExamplesConsole.AspNetCoreWebApp.lesson1
{
    internal static class example2
    {
        /// <summary>
        /// 
        /// </summary>
        internal static void Start()
        {
            Task.WaitAll(MakeCoffe(), MakePizza(), TakeShower());

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

        private static async Task MakePizza()
        {
            Console.WriteLine($"Pizza. Start making a pizza");
            await WorkEmulation(4000);
            Console.WriteLine($"Pizza. Pizza is Ready!");
        }

        private static async Task TakeShower()
        {
            Console.WriteLine($"Shower. Start taking a shower");
            await WorkEmulation(6000);
            Console.WriteLine($"Shower. Finish taking a shower!");
        }

        private static Task WorkEmulation(int milliseconds)
        {
            //return new Task(() => Thread.Sleep(milliseconds));
            return Task.Delay(milliseconds);
        }
    }
}
