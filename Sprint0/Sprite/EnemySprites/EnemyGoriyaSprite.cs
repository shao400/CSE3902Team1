using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint0.UtilityClass;

namespace Sprint0.Sprite
{
    public class EnemyGoriyaSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        Rectangle destinationRec;
        int frame = 0;
        bool backmove = false;
        SpriteEffects myEffect;

        public EnemyGoriyaSprite(int x, int y)
        {
            destinationRec = new Rectangle(x, y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive);
        }



        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < IntegerHolder.Ten && !backmove)
            {
                sourceRec = new Rectangle(256, 11, 16, 16);
                destinationRec.X += 1;
            }
            else if (frame > IntegerHolder.Ten && !backmove)
            {
                sourceRec = new Rectangle(273, 11, 16, 16);
                destinationRec.X += 1;
            }
            else if (frame < IntegerHolder.Ten && backmove)
            {

                sourceRec = new Rectangle(256, 11, 16, 16);
                destinationRec.X -= 1;
            }
            else if (frame > IntegerHolder.Ten && backmove)
            {

                sourceRec = new Rectangle(273, 11, 16, 16);
                destinationRec.X -= 1;
            }

            if (destinationRec.X > 627) backmove = true;
            if (destinationRec.X < IntegerHolder.NinetySix) backmove = false;
        }

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, bool isDamaged)
        {
            if (backmove) myEffect = SpriteEffects.FlipHorizontally;
            else myEffect = SpriteEffects.None;
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor, 0, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.End();
        }
    }
}
