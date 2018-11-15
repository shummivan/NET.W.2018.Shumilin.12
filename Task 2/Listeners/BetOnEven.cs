using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteDemo.Listeners
{
    /// <summary>
    /// Class simulating the bet on even
    /// </summary>
    public class BetOnEven : IRouletteSpin
    {
        /// <summary>
        /// Object notification of an event
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="eventArgs">Class that contains information about roulette</param>
        private void Msg(object sender, RouletteEventArgs eventArgs)
        {
            if (eventArgs.Number % 2 == 0)
            {
                Console.WriteLine("Win " + eventArgs.Number + " " + eventArgs.Color);
            }
            else
            {
                Console.WriteLine("Lose! Try one more time!");
            }
        }

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="roulette"></param>
        public void Register(Roulette roulette)
        {
            roulette.RouletteSpin += Msg;
        }

        /// <summary>
        /// Unregister
        /// </summary>
        /// <param name="roulette"></param>
        public void Unregister(Roulette roulette)
        {
            roulette.RouletteSpin -= Msg;
        }
    }
}
