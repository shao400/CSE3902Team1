using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint0.Interfaces
{
    public interface IItem
    {
        void Draw();
        void Update();
        Rectangle GetRectangle();
        
        
    }
}
