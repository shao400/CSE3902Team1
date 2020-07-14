using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    //Zina
    public class PlayerBombExplodingSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        SpriteEffects myEffect;
        int count = 0;

        public PlayerBombExplodingSprite()
        {           
        }


        public void Update()
        {
            if (count < 10) { count++; sourceRec = new Rectangle(138, 185, 16, 16); }
            else if (count < 20) { count++; sourceRec = new Rectangle(155, 185, 16, 16); }
            else if (count < 30) { count++; sourceRec = new Rectangle(172, 185, 16, 16); }
            else if (count == 30) { count = 0; sourceRec = new Rectangle(0, 0, 0, 0); }
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
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 48, 48), sourceRec, myColor, 0, new Vector2(0,0), myEffect, 0);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X - 48, (int)location.Y, 48, 48), sourceRec, myColor, 0, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X + 48, (int)location.Y, 48, 48), sourceRec, myColor, 0, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X - 36, (int)location.Y - 48, 48, 48), sourceRec, myColor, 0, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X + 36, (int)location.Y - 48, 48, 48), sourceRec, myColor, 0, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X - 36, (int)location.Y + 48, 48, 48), sourceRec, myColor, 0, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X + 36, (int)location.Y + 48, 48, 48), sourceRec, myColor, 0, new Vector2(0, 0), myEffect, 0);
            mySpriteBatch.End();
        }


    }
}

