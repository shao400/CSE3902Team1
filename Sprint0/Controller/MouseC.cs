using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint0.Controller
{
    class MouseC : IController
    {
        
        private Game1 myGame;

        public MouseC(Game1 game)
        {
            myGame = game;
        }

        public void Update()
        {
            var msState = Mouse.GetState();

            if (msState.LeftButton == ButtonState.Pressed)
            {
                new MouseLeftLastRM(myGame).Execute();
            }
            else if (msState.RightButton == ButtonState.Pressed)
            {
                new MouseRightNextRM(myGame).Execute();
            }
        }

    }
}