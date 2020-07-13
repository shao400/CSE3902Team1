using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Commands
{
    class Boom : ICommand
    {
        private Game1 myGame;

        public Boom(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.link.Boom();
        }
    }
}
