using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint0.UtilityClass;

namespace Sprint0.Sprite
{
    public class EnemyKeeseSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        Rectangle destinationRec;
        int frame = 0;
        bool backmove = false;

        public EnemyKeeseSprite(int x, int y)
        {
            destinationRec = new Rectangle(x, y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive);
        }



        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < IntegerHolder.Ten && !backmove)
            {
                sourceRec = new Rectangle(183, 11, 16, 16);
                destinationRec.Y += IntegerHolder.Three;
            }
            else if (frame > IntegerHolder.Ten && !backmove)
            {
                sourceRec = new Rectangle(200, 11, 16, 16);
                destinationRec.Y += IntegerHolder.Three;
            }
            else if (frame < IntegerHolder.Ten && backmove)
            {

                sourceRec = new Rectangle(183, 11, 16, 16);
                destinationRec.Y -= IntegerHolder.Three;
            }
            else if (frame > IntegerHolder.Ten && backmove)
            {

                sourceRec = new Rectangle(200, 11, 16, 16);
                destinationRec.Y -= IntegerHolder.Three;
            }

            if (destinationRec.Y > 555) backmove = true;
            if (destinationRec.Y < IntegerHolder.TwoSixFour) backmove = false;
        }

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, bool isDamaged)
        {

            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
