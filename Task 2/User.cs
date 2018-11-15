using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteDemo.Listeners;

namespace RouletteDemo
{
    /// <summary>
    /// Сlass simulating the user of roulette
    /// </summary>
    public class User
    {
        /// <summary>
        /// Name of user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Cash of user
        /// </summary>
        public int Cash { get; set; }
        /// <summary>
        /// Bet of user
        /// </summary>
        public int CurrentBet { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="cash">Cash</param>
        public User(string name, int cash)
        {
            Name = name;
            Cash = cash;
        }

        /// <summary>
        /// Bet on different cell
        /// </summary>
        /// <param name="rs">Bet on different cell</param>
        /// <param name="betAmount">Amount of bet</param>
        /// <param name="roulette">Roulette</param>
        public void Bet(IRouletteSpin rs, int betAmount, Roulette roulette)
        {            
            if (betAmount > Cash)
            {
                throw new ArgumentOutOfRangeException();
            }

            CurrentBet = betAmount;
            rs.Register(roulette);
        }
    }
}
