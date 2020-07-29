using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class EnemyMoblinSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        Rectangle destinationRec;
        int frame = 0;
        bool backmove = false;
        
        public EnemyMoblinSprite(int x, int y)
        {
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if(frame < 10 && !backmove )
            {
                sourceRec = new Rectangle(116, 11, 16, 16);
                destinationRec.X += 1;
            } 
            else if(frame >10 && !backmove)
            {
                sourceRec = new Rectangle(133, 11, 16, 16);
                destinationRec.X += 1;
            }
            else if(frame <10 && backmove){

                sourceRec = new Rectangle(153, 212, 16, 16);
                destinationRec.X -= 1;
            }
            else if (frame >10 && backmove){

                sourceRec = new Rectangle(170, 212, 16, 16);
                destinationRec.X -= 1;
            }

            if (destinationRec.X > 627) backmove = true;
            if (destinationRec.X < 96) backmove = false;
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
