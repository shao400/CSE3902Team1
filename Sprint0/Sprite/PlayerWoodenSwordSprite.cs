using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class PlayerWoodenSwordSprite : ISprite
    {
        //1,154,7,16 (whole)
        //1,154,7,13 (with green part)
        //3,154,3,11 (only sword)
        //final position link + (5,11) / (11,4) / (3,-12)
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        int frame = 0;
        Rectangle destinationRec;
        Rectangle sourceRec = new Rectangle(10, 159, 16, 7);


        public void Update()
        {
            
        }


        public void LoadContent(SpriteBatch batch, Texture2D f)
        {

            mySpriteBatch = batch;
            myTexture = f;

        }

        public void Draw(Vector2 location, Boolean isDamaged)
        {
            frame++;
            if (frame == 12)
            {
                frame = 0;
            }
            if (frame < 9)
            {
                destinationRec = new Rectangle((int)location.X+27, (int)location.Y+12, 45, 23);
            }
            else
            {
                //destinationRec = new Rectangle((int)location.X, (int)location.Y, 45, 21);
            }
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();

        }


    }
}

