using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;

namespace Sprint0.Sprite
{
    public class ItemHeartSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        

        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if(frame < 10)
            {
                sourceRec = new Rectangle(0, 0, 7, 8);
            } 
            else if(frame >10)
            {
                sourceRec = new Rectangle(0, 8, 7, 8);
            }
         }

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, bool isDamaged)
        {
            Rectangle destinationRec = new Rectangle((int)location.X, (int)location.Y, 28, 32);
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
