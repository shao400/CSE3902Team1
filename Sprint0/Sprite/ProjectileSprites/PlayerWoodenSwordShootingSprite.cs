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
    public class PlayerWoodenSwordShootingSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle destinationRec;
        Rectangle sourceRec = new Rectangle(IntegerHolder.Ten, 159, 16, IntegerHolder.Seven);
        SpriteEffects myEffect;
        float myRotation;

        public PlayerWoodenSwordShootingSprite(SpriteEffects effect, float rotation)
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
            if (myEffect == SpriteEffects.FlipHorizontally) destinationRec = new Rectangle((int)location.X - 28, (int)location.Y + 12, IntegerHolder.FoutyFive, 23); //left
            else if (myEffect == SpriteEffects.None && myRotation == 0) destinationRec = new Rectangle((int)location.X + 27, (int)location.Y + 12, IntegerHolder.FoutyFive, 23); //right
            else if (myEffect == SpriteEffects.None && myRotation < 0) destinationRec = new Rectangle((int)location.X + 12, (int)location.Y + 12, IntegerHolder.FoutyFive, 23);  //up
            else if (myEffect == SpriteEffects.None && myRotation > 0) destinationRec = new Rectangle((int)location.X + IntegerHolder.ThirtyFive, (int)location.Y + IntegerHolder.Thirty, IntegerHolder.FoutyFive, 23);  //down
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor, myRotation, new Vector2(0,0), myEffect, 0);
            mySpriteBatch.End();
        }


    }
}

