using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint0.UtilityClass;

namespace Sprint0.Sprite
{
    public class NStalfosSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        SpriteEffects myEffect;

        public NStalfosSprite()
        {

        }



        public void Update()
        {
            
        }

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, bool isDamaged)
        {
            sourceRec = new Rectangle(1, 59, 16, 16);
            if (isDamaged == true) myEffect = SpriteEffects.FlipHorizontally;
            else myEffect = SpriteEffects.None;
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive), sourceRec, myColor, 0, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.End();
        }
    }
}
