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
        ICommand currentCommand;
        IPlayer Link;
        //private enum SpriteState {quit, fixedSatic,fixedAnimated, movingStatic, movingAnimated }; not used
        SpriteState currentState = SpriteState.fixedSatic;
        private Dictionary<Keys, ICommands> keymap;
       

        public KeyboardC(Game1 game, Link link)
        {
            myGame = game;
            this.Link = link;
            commandLibrary = new Dictionary<Keys, ICommands>();
            commandLibrary.Add(Keys.W, currentCommand = new UpCommand(link));
            commandLibrary.Add(Keys.S, currentCommand = new DownCommand(link));
            commandLibrary.Add(Keys.A, currentCommand = new LeftCommand(link));
            commandLibrary.Add(Keys.D, currentCommand = new RightCommand(link));
            commandLibrary.Add(Keys.F, currentCommand = new AttackCommand(link));
            commandLibrary.Add(Keys.Q, currentCommand = new FirstItemCommand(link));
            commandLibrary.Add(Keys.E, currentCommand = new SecondItemCommand(link));
            commandLibrary.Add(Keys.R, currentCommand = new ThirdItemCommand(link));
          
            
        }
      

        public void Update()
        {
            //The following Sprint0 codes kept for test
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

            //
            
            currentCommand = new NullCommand();
            //GamePadState gamepadState = GamePad.GetState(PlayerIndex.One);
            Kstate = Keyboard.GetState();
            foreach (Keys key in Kstate.GetPressedKeys())
            {
                if (commandLibrary.ContainsKey(key))
                {
                    currentCommand = commandLibrary[key];
                    currentCommand.Execute();  
                } 
           }
            //mario.Idle();
        

        }
    }
}