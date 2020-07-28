using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class LinkUsingLeftSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Rectangle sourceRec = new Rectangle(124, 11, 16, 16);
        Color myColor = Color.GreenYellow;
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
            if (isDamaged) myColor = Color.Red;
            else myColor = Color.GreenYellow;
            Rectangle desRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 45);
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, desRectangle, sourceRec, myColor, 0, new Vector2(0,0), SpriteEffects.FlipHorizontally, 0);
            mySpriteBatch.End();
        }
    }
}
