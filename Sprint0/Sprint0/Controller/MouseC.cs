using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mouse = Microsoft.Xna.Framework.Input.Mouse;

namespace Sprint0.Controller
{
    class MouseC : IController
    {
        private Game1 myGame;
        private MouseState Mstate;
       


        public MouseC(Game1 game)
        {
            myGame = game;
           
        }



        public void Update()
        {
            if (Mouse.GetState().RightButton == ButtonState.Pressed)
            {
                myGame.Exit();
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && Mouse.GetState().X <=400 &&Mouse.GetState().Y<=240)
            {
                myGame.sprite = new fixedStaticSprite(myGame.luigi, 6, 14);
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && Mouse.GetState().X > 400 && Mouse.GetState().Y <= 240)
            {
                myGame.sprite = new fixedAnimatedSprite(myGame.luigi, 6, 14);
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && Mouse.GetState().X <= 400 && Mouse.GetState().Y > 240)
            {
                myGame.sprite = new movingStaticSprite(myGame.luigi, 6, 14);
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && Mouse.GetState().X > 400 && Mouse.GetState().Y > 240)
            {
                myGame.sprite = new movingAnimatedSprite(myGame.luigi, 6, 14);
            }
        }
    }
}