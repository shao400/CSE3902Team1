using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;

namespace Sprint0.Commands
{
    class qQuit : ICommand
    {
        private Game1 myGame;

        public qQuit(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.Exit();
        }

    }
}
