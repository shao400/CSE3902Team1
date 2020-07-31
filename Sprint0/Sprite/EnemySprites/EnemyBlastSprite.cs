using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint0.UtilityClass;

namespace Sprint0.Sprite
{
    public class EnemyBlastSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;


        public EnemyBlastSprite()
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
            Rectangle destinationRec = new Rectangle((int)location.X, (int)location.Y, 32, IntegerHolder.Fourty);
            sourceRec = new Rectangle(IntegerHolder.Ten, 215, IntegerHolder.Eight, IntegerHolder.Ten);
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
