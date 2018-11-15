using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteDemo
{
    /// <summary>
    /// Сlass simulating the game of roulette
    /// </summary>
    public class Roulette
    {
        /// <summary>
        /// Delegate for event
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">Class that contains information about roulette</param>
        public delegate void RouletteEventHandler(object sender, RouletteEventArgs e);

        /// <summary>
        /// Event roulette spin
        /// </summary>
        public event RouletteEventHandler RouletteSpin;

        /// <summary>
        /// Random
        /// </summary>
        Random r = new Random();

        /// <summary>
        /// Colors enum
        /// </summary>
        public enum Color
        {
            Green,
            Red,
            Black
        }

        /// <summary>
        /// User
        /// </summary>
        private User user;
        public User User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }

        /// <summary>
        /// Notifying registered objects of the event
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">Class that contains information about roulette</param>
        protected virtual void OnRouletteSpin(object sender, RouletteEventArgs e)
        {
            RouletteSpin?.Invoke(sender, e);
        }

        /// <summary>
        /// Spin the roulette
        /// </summary>
        public void Spin()
        {                
            int number = r.Next(0, 37);

            if (user.CurrentBet > user.Cash)
            {
                throw new ArgumentOutOfRangeException();
            }

            OnRouletteSpin(this, new RouletteEventArgs(number, User));
        }
    }
}
