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
using Microsoft.Xna.Framework.Content;
using Sprint0.Sprite;
using System.Windows;
using Sprint0.HUDs;
using Sprint0.UtilityClass;
using Sprint0.Inventories;

namespace Sprint0.GameStates
{
    class HandbookState : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        Rectangle pauseDestRec = new Rectangle(0, 0, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
        Rectangle pauseSourceRec = new Rectangle(0, 0, 797, 536);
        ContentManager myContent;
        Handbook myHandbook;
        private Hud myHud;

        public HandbookState(Game1 game, SpriteBatch batch, ContentManager Content, Hud hud1)
        {
            myGame = game;
            myBatch = batch;
            myContent = Content;
            myHud = hud1;
            myHandbook = game.link.myHandbook;
        }

        public void Draw()
        {            
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Handbook), pauseDestRec, pauseSourceRec, Color.White); ;
            myBatch.End();
            myHud.Draw(0, IntegerHolder.FiveTwoEight);
            myHandbook.pickingIcon(0);


        }

        public void loadNextRoom(int nextRoom)
        {

        }

        public void Update()
        {

        }

        public void NextOption()
        {

        }
        public void LastOption()
        {

        }
        public void Select()
        {

        }
    }
}