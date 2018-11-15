using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteDemo.Listeners
{
    public interface IRouletteSpin
    {
        void Register(Roulette roulette);
        void Unregister(Roulette roulette);
    }
}
