using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class FogSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec = new Rectangle(384, 348, 768, 696);
        SpriteEffects myEffect;
        float myRotation;
        Rectangle destinationRec;
        public void Update()
        {

        }
        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }
        public void Draw(Vector2 location, Boolean isDamaged)
        {

            destinationRec = new Rectangle((int)location.X - 2300, (int)location.Y - 2300, 4600, 4600);
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor, myRotation, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.End();
        }
    }
}