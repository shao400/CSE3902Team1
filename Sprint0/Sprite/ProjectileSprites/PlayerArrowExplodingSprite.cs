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
    public class PlayerArrowExplodingSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle destinationRec;
        Rectangle sourceRec = new Rectangle(149, 282, 17, 21);
        SpriteEffects myEffect;
        int finalX = 63;
        int finalY = 63;


        public PlayerArrowExplodingSprite(SpriteEffects effect)
        {
            myEffect = effect;
            
        }


        public void Update()
        {
            if (finalX < 80)
            {
                finalX++;
                finalY++;
            }
            else {
                finalX = 63;
                finalY = 63;
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
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor, 0, new Vector2(0,0), myEffect, 0);
            mySpriteBatch.End();
        }


    }
}

