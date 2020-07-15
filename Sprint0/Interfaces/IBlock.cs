using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint0.Interfaces
{
    public interface IBlock
    {
        void Draw();
        void Update();
        string GetType();
        Rectangle GetRectangle();

    }
}