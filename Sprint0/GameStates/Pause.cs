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
    class Pause : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        Rectangle pauseDestRec = new Rectangle(0, 0, 768, 528);
        Rectangle pauseSourceRec = new Rectangle(0, 0, 491, 325);
        ContentManager myContent;
        Inventory myInventory;
        private HudMap map;
        private Hud myHud;

        public Pause(Game1 game, SpriteBatch batch, ContentManager Content, Hud hud1)
        {
            myGame = game;
            myBatch = batch;
            myContent = Content;
            myHud = hud1;
            map = hud1.map;
            myInventory = game.link.myInventory;
        }

        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Pause), pauseDestRec, pauseSourceRec, Color.White); ;
            myBatch.End();
            myHud.Draw(0, 528);
            map.Draw(450, 450);
            myInventory.showItem();
            myInventory.pickingItem(0);

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