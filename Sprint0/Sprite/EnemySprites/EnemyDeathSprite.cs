﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class EnemyDeathSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        Rectangle destinationRec;
        int frame = 0;
        public void Update()
        {
            if (frame < 5) { sourceRec= new Rectangle(118, 189, 8, 8); }
            if (frame < 10) { sourceRec= new Rectangle(118, 189, 0, 0); }
            if (frame < 15) { sourceRec= new Rectangle(118, 189, 8, 8); frame = 0; }
        }

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, bool isDamaged)
        {
            destinationRec = new Rectangle((int)location.X,(int)location.Y,70,70);
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
