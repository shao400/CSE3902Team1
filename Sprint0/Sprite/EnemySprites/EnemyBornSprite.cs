﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class EnemyBornSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        Rectangle destinationRec;
        int frame = 0;

        public void Update()
        {
            frame++;
            if (frame < 5) { sourceRec = new Rectangle(138, 185, 16, 16); }
            else if (frame < 25) { sourceRec = new Rectangle(155, 185, 16, 16); }
            else if (frame < 35) { sourceRec = new Rectangle(172, 185, 16, 16); frame = 0; }
        }

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, bool isDamaged)
        {
            destinationRec = new Rectangle((int)location.X,(int)location.Y,45,45) ;
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
