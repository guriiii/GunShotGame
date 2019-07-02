using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShotGame
{
    class gameclass
    {
        public int lodspin;
        public int points = 0;
        public int shotway;
        public int remainingshot = 6;
        public int load = 0;
        public int loadgunrandom()
        {
            Random spin = new Random();

            lodspin = spin.Next(1, 6);//this puts the bulletet in next chamber

            return lodspin;
        }
    }
}
