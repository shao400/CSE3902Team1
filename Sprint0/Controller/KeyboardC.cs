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
    class KeyboardC : IController
    {
        
        private Game1 myGame;
        private KeyboardState state;
        //private enum SpriteState {quit, fixedSatic,fixedAnimated, movingStatic, movingAnimated }; 没用上
        //SpriteState currentState = SpriteState.fixedSatic;
        private Dictionary<Keys, ICommand> keymap;
       

        public KeyboardC(Game1 game)
        {
            myGame = game;
            keymap = new Dictionary<Keys, ICommand>();
            keymap.Add(Keys.W, new wUp(myGame));
            keymap.Add(Keys.S, new sDown(myGame));
            keymap.Add(Keys.A, new aLeft(myGame));
            keymap.Add(Keys.D, new dRight(myGame));
            //keymap.Add(Keys.A, new);
            //keymap.Add(Keys.S, new);
            //keymap.Add(Keys.D, new);
            //keymap.Add(Keys.D1, new);
            //keymap.Add(Keys.D2, new);
            //keymap.Add(Keys.D3, new);
        }
      

        public void Update()
        {
            state = Keyboard.GetState();
            Keys[] pressedKeys = state.GetPressedKeys();

            //if (pressedKeys.Length == 0)
            //{
                foreach (Keys key in pressedKeys)
                {
                //if (prev.IsKeyDown(key))
                //{
                if (keymap.ContainsKey(key))
                {
                    keymap[key].Execute();
                }
                    //}
                }
           // }
            //else
            //{
             //   foreach (Keys key in pressedKeys)
             //   {
             //       keymap[key].Execute();
             //   }
             //   prev = state;
            //}
        }
    }
}