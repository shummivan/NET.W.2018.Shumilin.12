using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteDemo.Listeners
{
    /// <summary>
    /// Class simulating the bet on number
    /// </summary>
    public class BetOnNumber : IRouletteSpin
    {
        /// <summary>
        /// Number
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// Constrctor
        /// </summary>
        /// <param name="number">Number</param>
        public BetOnNumber(int number)
        {
            Number = number;
        }

        /// <summary>
        /// Object notification of an event
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="eventArgs">Class that contains information about roulette</param>
        private void Msg(object sender, RouletteEventArgs eventArgs)
        {
            if (eventArgs.Number == Number)
            {
                Console.WriteLine("Win " + eventArgs.Number + " " + eventArgs.Color);
            }
            else
            {
                Console.WriteLine("Lose! Try one more time!");
            }
        }

        public void Register(Roulette roulette)
        {
            roulette.RouletteSpin += Msg;
        }

        public void Unregister(Roulette roulette)
        {
            roulette.RouletteSpin -= Msg;
        }
    }
}
