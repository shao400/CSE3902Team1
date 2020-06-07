using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class ItemGirlSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        Rectangle destinationRec = new Rectangle(300, 100, 30, 60);
        int frame = 0;
        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if(frame < 10)
            {
                sourceRec = new Rectangle(40, 0, 8, 16);
            } 
            else
            {
                sourceRec = new Rectangle(48, 0, 8, 16);
            }
        }

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, Boolean isDamaged)
        {
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
