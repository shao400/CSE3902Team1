using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class NAquaSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        Rectangle destinationRec;
        int frame = 0;
        SpriteEffects myEffect;

        public NAquaSprite()
        {
        }



        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < 10)
            {
                sourceRec = new Rectangle(1, 11, 24, 32);
            }
            else if (frame > 10)
            {
                sourceRec = new Rectangle(26, 11, 24, 32);
            }

        }

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, bool isDamaged)
        {
            if (isDamaged == true) myEffect = SpriteEffects.FlipHorizontally;
            else myEffect = SpriteEffects.None;
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 45, 45), sourceRec, myColor, 0, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.End();
        }
    }
}
