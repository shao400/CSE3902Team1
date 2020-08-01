using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint0.UtilityClass;
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
            frame++;
            if (frame < IntegerHolder.Five) { sourceRec= new Rectangle(118, 189, IntegerHolder.Eight, IntegerHolder.Eight); }
            else if (frame < 10) { sourceRec = new Rectangle(138, 185, 16, 16); }
            else if (frame < 15) { sourceRec= new Rectangle(118, 189, IntegerHolder.Eight, IntegerHolder.Eight); frame = 0; }
        }

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, bool isDamaged)
        {
            destinationRec = new Rectangle((int)location.X,(int)location.Y, IntegerHolder.Seventy, IntegerHolder.Seventy);
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
