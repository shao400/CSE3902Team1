using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Commands
{
    class eTakeDmg : ICommand
    {
        private Game1 myGame;

        public eTakeDmg(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.currentRoom.link.takeDmg();
        }
    }
}
