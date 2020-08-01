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
        private MouseState prev, state;
        

        public MouseC(Game1 game)
        {
            myGame = game;
            prev = Mouse.GetState();
        }

        public void Update()
        {
            state = Mouse.GetState();

            if (state.LeftButton == ButtonState.Pressed && prev.LeftButton == ButtonState.Released && myGame.currentState == myGame.stateList[0] )
            {
                new MouseLeftLastRM(myGame).Execute();
                prev = state;
            }
            else if (state.RightButton == ButtonState.Pressed && prev.RightButton == ButtonState.Released && myGame.currentState == myGame.stateList[0] )
            {
                new MouseRightNextRM(myGame).Execute();
                prev = state;
            }
            else if (state.RightButton == ButtonState.Released && state.LeftButton == ButtonState.Released)
            {
                prev = state;
            }
        }

    }
}