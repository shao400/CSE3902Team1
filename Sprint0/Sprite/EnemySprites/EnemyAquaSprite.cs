﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class EnemyAquaSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        Rectangle destinationRec;
        int frame = 0;
        bool backmove = false;

        public EnemyAquaSprite(int x, int y)
        {
            destinationRec = new Rectangle(x, y, 100, 100);
        }



        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < 10 && !backmove)
            {
                sourceRec = new Rectangle(1, 11, 24, 32);
                destinationRec.X += 1;
            }
            else if (frame > 10 && !backmove)
            {
                sourceRec = new Rectangle(26, 11, 24, 32);
                destinationRec.X += 1;
            }
            else if (frame < 10 && backmove)
            {

                sourceRec = new Rectangle(1, 11, 24, 32);
                destinationRec.X -= 1;
            }
            else if (frame > 10 && backmove)
            {

                sourceRec = new Rectangle(26, 11, 24, 32);
                destinationRec.X -= 1;
            }

            if (destinationRec.X > 470) backmove = true;
            if (destinationRec.X < 440) backmove = false;
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
