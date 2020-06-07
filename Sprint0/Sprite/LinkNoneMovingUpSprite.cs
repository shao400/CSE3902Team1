using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class LinkNoneMovingUpSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        int shownFrame = 0;
        public void Update()
        {
            shownFrame++;
            if (shownFrame == 20)
            {
                shownFrame = 0;
            }
            if (shownFrame < 10)
            {
                frame = 0;
            }
            else if (shownFrame < 20)
            {
                frame = 1;
            }
        }
        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }
        public void Draw(Vector2 location, Boolean isDamaged)
        {
            if (isDamaged)
            {
                myColor = Color.GreenYellow;
            }
            else
            {
                myColor = Color.CornflowerBlue;
            }
            if (frame == 0)
                sourceRec = new Rectangle(69, 11, 16, 16);
            if (frame == 1)
                sourceRec = new Rectangle(86, 11, 16, 16);


            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 48, 48), sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
