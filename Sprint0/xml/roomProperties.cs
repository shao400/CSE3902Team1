using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Sprint0.xml
{

    //Author: Chuwen Sun
    public class roomProperties
    {
        ContentManager myContent;
        SpriteBatch myBatch;
        public int roomID;
        public List<IBlock> blockList;
        public List<IItem> itemList;
        public List<IEnemy> enemyList;
        public List<IWallCube> cubeList;
        public List<IRoom> roomList;
        public List<IHud> hudList;
        public Rectangle sourceRec;
        public Rectangle DestRec;
        //Connectors is a collection of max 4 integers represents rooms connected to the current room in{up, down, left, right} order. 
        //If there is no access to one direction, -1 will be presented.
        public List<int> Connectors;  
        //Constructor method
        public roomProperties(int id, List<IBlock> b, List<IItem> i, List<IEnemy> e, List<IRoom> r, List<IHud> h, List<IWallCube> w, Rectangle source, List<int> con)
        {
            roomID = id;
            itemList = i;
            enemyList = e;
            blockList = b;
            roomList = r;
            hudList = h;
            cubeList = w;
            sourceRec = source;
            DestRec = new Rectangle(0, 168, 768, 528);
            Connectors = con;
        }
        public void loadBatchAndContent(ContentManager Content, SpriteBatch Batch)
        {
            myContent = Content;
            myBatch = Batch;
        }
        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>("dungeon"), DestRec, sourceRec, Color.White);
            myBatch.End();
            for (int i = 0; i < hudList.Count; i++)
            {
                //hudList[i].Draw();
            }
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Draw();
            }
            for (int i = 0; i < itemList.Count; i++)
            {
                itemList[i].Draw();
            }
        }

        public void Update()
        {
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Update();
            }
            for (int i = 0; i < itemList.Count; i++)
            {
                itemList[i].Update();
            }
            for (int i = 0; i < blockList.Count; i++)
            {
                blockList[i].Update();
            }
            for (int i = 0; i < roomList.Count; i++)
            {
                roomList[i].Update();
            }
            for (int i = 0; i < hudList.Count; i++)
            {
                hudList[i].Update();
            }
            for (int i = 0; i < cubeList.Count; i++)
            {
                cubeList[i].Update();
            }
        }
    }
}
