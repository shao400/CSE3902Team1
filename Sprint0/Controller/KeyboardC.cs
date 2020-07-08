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
        private Dictionary<Keys, ICommand> keymap, attackmap;
        private KeyboardState prevKeyState, prevAttackState, state;
       

        public KeyboardC(Game1 game)
        {
            myGame = game;
            prevKeyState = Keyboard.GetState();
            prevAttackState = Keyboard.GetState();
            keymap = new Dictionary<Keys, ICommand>();
            attackmap = new Dictionary<Keys, ICommand>();
            keymap.Add(Keys.W, new wUp(myGame));
            keymap.Add(Keys.S, new sDown(myGame));
            keymap.Add(Keys.A, new aLeft(myGame));
            keymap.Add(Keys.D, new dRight(myGame));

            keymap.Add(Keys.Up, new wUp(myGame));
            keymap.Add(Keys.Down, new sDown(myGame));
            keymap.Add(Keys.Left, new aLeft(myGame));
            keymap.Add(Keys.Right, new dRight(myGame));

            keymap.Add(Keys.Q, new qQuit(myGame));
            keymap.Add(Keys.R, new rReset(myGame));
            keymap.Add(Keys.D1, new D1FirstWeapon(myGame));
            keymap.Add(Keys.D2, new D2SecondWeapon(myGame));
            keymap.Add(Keys.D3, new D3ThirdWeapon(myGame));
            keymap.Add(Keys.D4, new D4FourthWeapon(myGame));
            attackmap.Add(Keys.Z, new Attack(myGame));
            attackmap.Add(Keys.N, new Shoot(myGame));
        }

        //check no keys
        public void Update()
        {
            //keymap executing
            state = Keyboard.GetState();
            Keys[] pressedKeys = state.GetPressedKeys();
            foreach (Keys key in pressedKeys)
            {
                if (keymap.ContainsKey(key))
                {
                    keymap[key].Execute();
                }
                prevKeyState = state;
            }
            if (pressedKeys.Length == 0)
            {
                new Stand(myGame).Execute();
            }

            //attack button executing, different logic from other keys
            
            foreach (Keys key in attackmap.Keys)
            {
                if (state.IsKeyDown(key) && !prevAttackState.IsKeyDown(key))
                {
                    attackmap[key].Execute();
                    prevAttackState = state;
                } else if (prevAttackState.IsKeyDown(key))
                {
                    prevAttackState = state;
                }
            }
            
        }
    }
}