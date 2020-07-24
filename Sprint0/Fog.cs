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
using Sprint0.UtilityClass;

namespace Sprint0.GameStates
{
    class Fog
    {
        SpriteBatch myBatch;
        ContentManager myContent;

        public Fog(SpriteBatch batch, ContentManager Content)
        {
            myBatch = batch;
            myContent = Content;
        }

        public void GetPlayerLoction()
        {
            location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
        }

        public void Draw()
        {
            myBatch.Begin();
            //?string holder
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.GameOver), DestRec, SourceRec, Color.White);
            myBatch.End();
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
