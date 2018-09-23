using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_Rechner_Shit
{
    static class MathFuck
    {
        public static double DmgReduction(int armor) => armor / (armor + 300d);

        public static double FakeLife(int life, int armor, int shield) => (life / (1 - DmgReduction(armor))) + shield;
    }
}
