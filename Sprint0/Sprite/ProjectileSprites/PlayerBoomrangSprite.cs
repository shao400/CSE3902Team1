using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class PlayerBoomrangSprite : ISprite
    {
        
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle destinationRec;
        Rectangle sourceRec;
        SpriteEffects myEffect;
        float myRotation;
        int count = 0;

        public PlayerBoomrangSprite(SpriteEffects effect, float rotation)
        {
            myEffect = effect;
            myRotation = rotation;
            
        }


        public void Update()
        {
            count++;
            if (count < 10) { sourceRec= new Rectangle(65, 189, 5, 8); }
            else if (count < 20) { sourceRec = new Rectangle(73, 189, 8, 8); }
            else if (count < 30) { sourceRec = new Rectangle(82, 191, 8, 5); }
            else { count = 0; }   
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

