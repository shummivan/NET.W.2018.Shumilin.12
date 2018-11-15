using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteDemo;
using RouletteDemo.Listeners;
using Fibonacci;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var roulette = new Roulette();
            var listeners = new BetOnNumber(2);
            var listeners2 = new BetOnBlack();
            var listeners3 = new BetOnRed();

            //listeners.Register(roulette);
            //listeners2.Register(roulette);
            //listeners3.Register(roulette);

            User user = new User("Ivan", 2010);
            roulette.User = user;
            user.Bet(listeners2, 100, roulette);

            Console.WriteLine("Spin");
            for (int i = 0; i < 100; i++)
            {
                roulette.Spin();
                Console.WriteLine(user.Name + " " + user.Cash);
            }
            Console.WriteLine("End");

            Console.WriteLine("------------------------------");

            FibonacciDemo fd = new FibonacciDemo();

            foreach (var item in fd.GetFib(58))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");

            Console.ReadKey();
        }
    }
}
