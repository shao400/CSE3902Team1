using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
//Author: Gengyi Qin
namespace Sprint0
{
    public interface IPlayer
    {
        void Draw();
        void Update();
        Rectangle GetRectangle(); // use it to get the location of items etc.
        void Right();
        void Left();
        void Up();
        void Down();
        void Attack();
        Sound GetSound();
        void takeDmg(int v);
        Game1 GetGame();
    }
}
