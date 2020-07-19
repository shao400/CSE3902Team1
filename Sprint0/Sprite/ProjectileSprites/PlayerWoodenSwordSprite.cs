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
        Rectangle destinationRec;
        Rectangle sourceRec = new Rectangle(10, 159, 16, 7);
        SpriteEffects myEffect;
        float myRotation;

        public PlayerWoodenSwordSprite(SpriteEffects effect, float rotation)
        {
            myEffect = effect;
            myRotation = rotation;            
        }


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
            if (myEffect == SpriteEffects.FlipHorizontally) destinationRec = new Rectangle((int)location.X - 28, (int)location.Y + 12, 45, 23); //left
            else if (myEffect == SpriteEffects.None && myRotation == 0) destinationRec = new Rectangle((int)location.X + 27, (int)location.Y + 12, 45, 23); //right
            else if (myEffect == SpriteEffects.None && myRotation < 0) destinationRec = new Rectangle((int)location.X + 12, (int)location.Y + 12, 45, 23);  //up
            else if (myEffect == SpriteEffects.None && myRotation > 0) destinationRec = new Rectangle((int)location.X + 35, (int)location.Y + 30, 45, 23);  //down
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor, myRotation, new Vector2(0,0), myEffect, 0);
            mySpriteBatch.End();
        }


    }
}

