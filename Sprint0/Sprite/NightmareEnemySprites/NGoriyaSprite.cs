using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint0.UtilityClass;

namespace Sprint0.Sprite
{
    public class NGoriyaSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        SpriteEffects myEffect;

        public NGoriyaSprite()
        {
            
        }



        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < IntegerHolder.Ten)
            {
                sourceRec = new Rectangle(256, 11, 16, 16);
            }
            else if (frame > IntegerHolder.Ten)
            {
                sourceRec = new Rectangle(273, 11, 16, 16);
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
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive), sourceRec, myColor, 0, new Vector2(0,0), myEffect, 0);
            mySpriteBatch.End();
        }
    }
}
