using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteDemo
{
    /// <summary>
    /// Class that contains information about roulette
    /// </summary>
    public class RouletteEventArgs : EventArgs
    {      
        /// <summary>
        /// Number of cell
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// Array contains number of black cell
        /// </summary>
        private int[] blackNumbers = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35};

        /// <summary>
        /// Color of the cell
        /// </summary>
        public Roulette.Color Color { get; }

        /// <summary>
        /// User
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="user">User</param>
        public RouletteEventArgs(int number, User user)
        {
            Number = number;
            User = user;

            if (number == 0)
            {
                Color = Roulette.Color.Green;
            }
            else if (blackNumbers.Contains(number))
            {
                Color = Roulette.Color.Black;
            }
            else
            {
                Color = Roulette.Color.Red;
            }
        }
    }
}
