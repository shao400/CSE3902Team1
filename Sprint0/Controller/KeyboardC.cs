using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint0.Controller
{
    class KeyboardC : IController
    {
        private Game1 myGame;
        private KeyboardState Kstate;
        private enum SpriteState {quit, fixedSatic,fixedAnimated, movingStatic, movingAnimated };
        SpriteState currentState = SpriteState.fixedSatic;
        //private Dictionary<Keys, PossibleCommands> keymap;
       

        public KeyboardC(Game1 game)
        {
            myGame = game;
            
        }
      

        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D0))
            {
                myGame.Exit();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D1))
            {
                myGame.sprite = new fixedStaticSprite(myGame.luigi, 6, 14);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D2))
            {
                myGame.sprite = new fixedAnimatedSprite(myGame.luigi, 6, 14);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D3))
            {
                myGame.sprite = new movingStaticSprite(myGame.luigi, 6, 14);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D4))
            {
                myGame.sprite = new movingAnimatedSprite(myGame.luigi, 6, 14);
            }
        }
    }
}