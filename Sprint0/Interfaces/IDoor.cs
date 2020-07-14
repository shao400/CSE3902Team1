using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint0.Interfaces
{
    public interface IDoor
    {
        void Draw();
        void Update();
        Rectangle GetRectangle();

    }
}