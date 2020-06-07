﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Commands
{
    class Attack : ICommand
    {
        private Game1 myGame;

        public Attack(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.player1.Attack();
        }
    }
}