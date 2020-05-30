using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.State
{
    class P1State
    {
        private enum facing
        {
            up, down, left, right
        }

        private enum weapon
        {
            none, WoodenSword, WhiteSword, MagicalSword, MagicalRod
        }

        private bool isAttacking;
        private bool isTakingDmg;

    }
}
