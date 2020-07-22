using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0.xml;
using Sprint0.HUDs;
using Sprint0.UtilityClass;
using Microsoft.Xna.Framework.Content;

namespace Sprint0.GameStates
{
    class Menu : IGameState
    {
        Game1 myGame;
        
        int x = 0;
        int y = 0;
        SpriteFont myFont;
        SpriteBatch myBatch;
        List<string> options;
        ContentManager myContent;
        int currentOpt;
        public Menu(Game1 game, SpriteBatch Batch, ContentManager Content)

        {
            myContent = Content;
            myFont = myContent.Load<SpriteFont>("myFont");
            options = new List<string>();
            options.Add(StringHolder.Play);
            options.Add(StringHolder.NightmareMode);
            options.Add(StringHolder.Restart);
            myGame = game;          
            myBatch = Batch;
            currentOpt = 0;
        }
        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>("menu"), new Rectangle(114, 43, 540, 288), new Rectangle(37, 43, 180, 96), Color.White);
            for (int i = 0; i < options.Count; i++)
            {
                Color color = Color.White;
                if (i == currentOpt)
                    color = Color.Black;
                
                myBatch.DrawString(myFont, options[i], new Vector2(768 / 2 - myFont.MeasureString(options[i]).X / 2, 500 + i * 36), color);
            }
            myBatch.DrawString(myFont, StringHolder.Instruction, new Vector2(0, 678), Color.Black);
            myBatch.End();
        }

        public void Update()
        {

        }
        public void loadNextRoom(int nextRoom)
        {
            
        }

        public void NextOption()
        {
            if(currentOpt >= 2)
            {
                currentOpt = 0;
            }
            else
            {
                currentOpt++;
            }
        }

        public void LastOption()
        {
            if (currentOpt <= 0)
            {
                currentOpt = 2;
            }
            else
            {
                currentOpt--;
            }
        }

        public void Select()
        {
            switch (currentOpt)
            {
                case 0:
                    myGame.currentState = myGame.stateList[0];
                    break;
                case 1:
                    myGame.currentState = myGame.stateList[0];
                    break;
                case 2:
                    myGame.currentState = myGame.stateList[0];
                    break;
            }
        }

    }
}
