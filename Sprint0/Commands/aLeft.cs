using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Commands
{
    class aLeft : ICommand
    {
        private Game1 myGame;

        public aLeft(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
           if(myGame.currentState == myGame.stateList[8])
            {
               
            }
            myGame.link.Left();
        }

    }
}
