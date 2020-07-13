using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint0.Interfaces
{
    public interface IEnemy
    {
        void Draw();
        void Damaged();
        int GetHealth();
        void Update(/*to be determined*/);
        Rectangle GetRectangle();
        
    }
}
