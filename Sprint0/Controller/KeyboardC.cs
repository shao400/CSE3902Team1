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
        //private enum SpriteState {quit, fixedSatic,fixedAnimated, movingStatic, movingAnimated }; 没用上
        //SpriteState currentState = SpriteState.fixedSatic;
        private Dictionary<Keys, ICommand> keymap;
        private KeyboardState prev, state;
       

        public KeyboardC(Game1 game)
        {
            myGame = game;
            prev = Keyboard.GetState();
            keymap = new Dictionary<Keys, ICommand>();
            keymap.Add(Keys.W, new wUp(myGame));
            keymap.Add(Keys.S, new sDown(myGame));
            keymap.Add(Keys.A, new aLeft(myGame));
            keymap.Add(Keys.D, new dRight(myGame));
            keymap.Add(Keys.O, new oNextEnemy(myGame));
            keymap.Add(Keys.P, new pPrevEnemy(myGame));
            keymap.Add(Keys.T, new tSwitchBlock(myGame));//Block commands
            keymap.Add(Keys.Y, new ySwitchBlock(myGame));
            keymap.Add(Keys.U, new uNextItem(myGame));
            keymap.Add(Keys.I, new iPrevItem(myGame));
            keymap.Add(Keys.Q, new qQuit(myGame));
            keymap.Add(Keys.R, new rReset(myGame));
            keymap.Add(Keys.Z, new Attack(myGame));
            keymap.Add(Keys.N, new Attack(myGame));
            keymap.Add(Keys.D1, new D1FirstWeapon(myGame));
            keymap.Add(Keys.D2, new D2SecondWeapon(myGame));
            keymap.Add(Keys.D3, new D3ThirdWeapon(myGame));
            keymap.Add(Keys.D4, new D4FourthWeapon(myGame));
        }

        //check no keys
        public void Update()
        {
            state = Keyboard.GetState();
            Keys[] pressedKeys = state.GetPressedKeys();
            foreach (Keys key in pressedKeys)
            {
                if (keymap.ContainsKey(key))
                {
                    keymap[key].Execute();
                }
               /* if (state.IsKeyDown(key) && !prev.IsKeyDown(key))
                {
                    if (keymap.ContainsKey(key))
                    {
                        keymap[key].Execute();
                    }
                }

                if (state.IsKeyUp(key) && prev.IsKeyDown(key))
                {
                    new Stand(myGame).Execute();
                }*/
                prev = state;
            }
            if (pressedKeys.Length == 0)
            {
                new Stand(myGame).Execute();
            }
        }
    }
}