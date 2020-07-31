using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint0.UtilityClass;

namespace Sprint0.Sprite
{
    //Zina
    public class PlayerBombExplodingSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int count = 0;

        public PlayerBombExplodingSprite()
        {           
        }


        public void Update()
        {
            if (count < IntegerHolder.Ten) { count++; sourceRec = new Rectangle(138, 185, 16, 16); }
            else if (count < 20) { count++; sourceRec = new Rectangle(155, 185, 16, 16); }
            else if (count < IntegerHolder.Thirty) { count++; sourceRec = new Rectangle(172, 185, 16, 16); }
            else if (count == IntegerHolder.Thirty) { count = 0; sourceRec = new Rectangle(0, 0, 0, 0); }
            //else { count = 0; }
        }


        public void LoadContent(SpriteBatch batch, Texture2D f)
        {
            mySpriteBatch = batch;
            myTexture = f;
        }

        public void Draw(Vector2 location, Boolean isDamaged)
        {

            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, IntegerHolder.fourtyEight, IntegerHolder.fourtyEight), sourceRec, myColor);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X - IntegerHolder.fourtyEight, (int)location.Y, IntegerHolder.fourtyEight, IntegerHolder.fourtyEight), sourceRec, myColor);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X + IntegerHolder.fourtyEight, (int)location.Y, IntegerHolder.fourtyEight, IntegerHolder.fourtyEight), sourceRec, myColor);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X - 36, (int)location.Y - IntegerHolder.fourtyEight, IntegerHolder.fourtyEight, IntegerHolder.fourtyEight), sourceRec, myColor);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X + 36, (int)location.Y - IntegerHolder.fourtyEight, IntegerHolder.fourtyEight, IntegerHolder.fourtyEight), sourceRec, myColor);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X - 36, (int)location.Y + IntegerHolder.fourtyEight, IntegerHolder.fourtyEight, IntegerHolder.fourtyEight), sourceRec, myColor);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X + 36, (int)location.Y + IntegerHolder.fourtyEight, IntegerHolder.fourtyEight, IntegerHolder.fourtyEight), sourceRec, myColor);
            mySpriteBatch.End();
        }


    }
}

