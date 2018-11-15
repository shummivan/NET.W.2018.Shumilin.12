using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteDemo;

namespace RouletteDemo
{
    public class BetOnNumber
    {
        public int Number { get; }

        public BetOnNumber(int number)
        {
            Number = number;
        }

        private void Msg(object sender, RouletteEventArgs eventArgs)
        {
            if (eventArgs.Number == Number)
            {
                Console.WriteLine("Win " + Number + eventArgs.Color);
            }
        }

        public void Register(RouletteManager roulette)
        {
            roulette.RouletteSpin += Msg;
        }

        public void Unregister(RouletteManager roulette)
        {
            roulette.RouletteSpin -= Msg;
        }
    }
}
