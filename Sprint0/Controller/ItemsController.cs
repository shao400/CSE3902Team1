using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Commands;
using Microsoft.Xna.Framework.Input;

namespace Sprint0.Controller
{
    class ItemsController : IController
    {
        private Game1 myGame;
        private Dictionary<Keys, ICommand> keymap;
        private KeyboardState prev, state;

        public ItemsController(Game1 game)
        {
            myGame = game;
            prev = Keyboard.GetState();
            keymap = new Dictionary<Keys, ICommand>();
            keymap.Add(Keys.O, new oNextEnemy(myGame));
            keymap.Add(Keys.P, new pPrevEnemy(myGame));
            keymap.Add(Keys.T, new tSwitchBlock(myGame));//Block commands
            keymap.Add(Keys.Y, new ySwitchBlock(myGame));
            keymap.Add(Keys.U, new uNextItem(myGame));
            keymap.Add(Keys.I, new iPrevItem(myGame));
        }

        public void Update()
        {
            state = Keyboard.GetState();
            Keys[] pressedKeys = state.GetPressedKeys();
            foreach (Keys key in pressedKeys)
            {
                if (state.IsKeyDown(key) && !prev.IsKeyDown(key))
                {
                    if (keymap.ContainsKey(key))
                    {
                        keymap[key].Execute();
                        prev = state;
                    }                    
                }
            }
            if (pressedKeys.Length==0)
            {
                prev = state;
            }
        }
    }
    }
