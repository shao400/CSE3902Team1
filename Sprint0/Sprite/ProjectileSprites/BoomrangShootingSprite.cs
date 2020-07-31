using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint0.UtilityClass;

namespace Sprint0.Sprite
{
    //Zina
    public class PlayerBoomrangShootingSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle destinationRec;
        Rectangle sourceRec;
        SpriteEffects myEffect;
        float myRotation;
        int count = 0;

        public PlayerBoomrangShootingSprite(SpriteEffects effect, float rotation)
        {
            myEffect = effect;
            myRotation = rotation;

        }


        public void Update()
        {
            count++;
            if (count < IntegerHolder.Ten) { sourceRec = new Rectangle(65, 189, IntegerHolder.Five, IntegerHolder.Eight); }
            else if (count < 20) { sourceRec = new Rectangle(73, 189, IntegerHolder.Eight, IntegerHolder.Eight); }
            else if (count < IntegerHolder.Thirty) { sourceRec = new Rectangle(82, 191, IntegerHolder.Eight, IntegerHolder.Five); }
            else { count = 0; }
        }


        public void LoadContent(SpriteBatch batch, Texture2D f)
        {
            mySpriteBatch = batch;
            myTexture = f;
        }

        public void Draw(Vector2 location, Boolean isDamaged)
        {
            if (myEffect == SpriteEffects.FlipHorizontally) destinationRec = new Rectangle((int)location.X - 28, (int)location.Y + 12, 24, 24); //left
            else if (myEffect == SpriteEffects.None && myRotation == 0) destinationRec = new Rectangle((int)location.X + 27, (int)location.Y + 12, 24, 24); //right
            else if (myEffect == SpriteEffects.None && myRotation < 0) destinationRec = new Rectangle((int)location.X + 12, (int)location.Y + 12, 24, 24);  //up
            else if (myEffect == SpriteEffects.None && myRotation > 0) destinationRec = new Rectangle((int)location.X + IntegerHolder.ThirtyFive, (int)location.Y + IntegerHolder.Thirty, 24, 24);  //down
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor, myRotation, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.End();
        }


    }
}

