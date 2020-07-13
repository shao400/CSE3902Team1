using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    //Zina
    public class PlayerBoomSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle destinationRec;
        Rectangle sourceRec;
        SpriteEffects myEffect;
        int finalX = 0;
        int finalY = 0;


        public PlayerBoomSprite(SpriteEffects effect)
        {
            myEffect = effect;

        }



        public void Update()
        {
            if (finalX < 63) { 
                sourceRec= new Rectangle(129, 3, 5, 8);
            }
            else if (finalX < 80)
            {
                sourceRec= new Rectangle(209, 282, 17, 21);
                finalX++;
                finalY++;
            }else if (finalX == 80)
            {
                sourceRec= new Rectangle(209, 282, 17, 21);
                finalX = 0;
                finalY = 0;
            }
        }


        public void LoadContent(SpriteBatch batch, Texture2D f)
        {
            mySpriteBatch = batch;
            myTexture = f;
        }

        public void Draw(Vector2 location, Boolean isDamaged)
        {

            destinationRec = new Rectangle((int)location.X, (int)location.Y, finalX, finalY);
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor, 0, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.End();
        }


    }
}

