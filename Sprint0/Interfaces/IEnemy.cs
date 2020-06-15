using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint0.Interfaces
{
    interface IEnemy
    {
        void Draw();
        void Fall(/*to be determined*/);
        void Reverse(/*to be determined*/);
        void Update(/*to be determined*/);
        Rectangle GetRectangle();
    }
}
