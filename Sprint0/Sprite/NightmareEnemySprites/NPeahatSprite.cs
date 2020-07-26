﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class NPeahatSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        public NPeahatSprite()
        {
        }
        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;

            if (frame < 10)
            {
                sourceRec = new Rectangle(162, 59, 16, 16);
            }
            else if (frame > 10)
            {
                sourceRec = new Rectangle(179, 59, 16, 16);
            }

        }
        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, bool isDamaged)
        {
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 45, 45), sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}