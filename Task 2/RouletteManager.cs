using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteDemo
{
    public class RouletteManager
    {
        public delegate void RouletteEventHandler(object sender, RouletteEventArgs e);

        public event RouletteEventHandler RouletteSpin;

        protected virtual void OnRouletteSpin(object sender, RouletteEventArgs e)
        {
            RouletteSpin?.Invoke(sender, e);
        }

        public void SimulateRouletteSpin(int number)
        {
            OnRouletteSpin(this, new RouletteEventArgs(number));
        }
    }
}
