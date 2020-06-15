using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint0.Interfaces
{
    interface IItem
    {
        Rectangle GetRectangle();
        void Update();
    }
}
