using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class FogSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        int shownFrame = 0;
        SpriteEffects myEffect;
        float myRotation;
        Rectangle destinationRec;
        public FogSprite(SpriteEffects effect, float rotation)
        {
            myEffect = effect;
            myRotation = rotation;

        }
        public void Update()
        {
            shownFrame++;
            if (shownFrame == 20)
            {
                shownFrame = 0;
            }
            if (shownFrame < 10)
            {
                frame = 0;
            }
            else if (shownFrame < 20)
            {
                frame = 1;
            }
        }
        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }
        public void Draw(Vector2 location, Boolean isDamaged)
        {
            
            if (frame == 0)
                sourceRec = new Rectangle(69, 11, 16, 16);
            //fog animated sprite1
            if (frame == 1)
                sourceRec = new Rectangle(86, 11, 16, 16);
            //fog animated sprite 2

            //change rotation with link, square move with link
            if (myEffect == SpriteEffects.FlipHorizontally) destinationRec = new Rectangle((int)location.X - 28, (int)location.Y + 12, 45, 23); //left
            else if (myEffect == SpriteEffects.None && myRotation == 0) destinationRec = new Rectangle((int)location.X + 27, (int)location.Y + 12, 45, 23); //right
            else if (myEffect == SpriteEffects.None && myRotation < 0) destinationRec = new Rectangle((int)location.X + 12, (int)location.Y + 12, 45, 23);  //up
            else if (myEffect == SpriteEffects.None && myRotation > 0) destinationRec = new Rectangle((int)location.X + 35, (int)location.Y + 30, 45, 23);  //down
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor, myRotation, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.End();
        }
    }
}
