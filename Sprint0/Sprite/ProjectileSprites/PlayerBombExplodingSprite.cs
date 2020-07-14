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
    public class PlayerBombExplodingSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle destinationRec;
        Rectangle sourceRec;
        SpriteEffects myEffect;
        int count = 0;

        public PlayerBombExplodingSprite(SpriteEffects effect)
        {
            myEffect = effect;
            
        }


        public void Update()
        {
            if (count < 20) { sourceRec = new Rectangle(138, 185, 16, 16); }
            if (count < 40) { sourceRec = new Rectangle(155, 185, 16, 16); }
            if (count < 60) { sourceRec = new Rectangle(172, 185, 16, 16); }
            if (count == 60) { count = 0; }
        }


        public void LoadContent(SpriteBatch batch, Texture2D f)
        {
            mySpriteBatch = batch;
            myTexture = f;
        }

        public void Draw(Vector2 location, Boolean isDamaged)
        {

            destinationRec = new Rectangle((int)location.X, (int)location.Y, 48, 48);
            destinationRec = new Rectangle((int)location.X - 48, (int)location.Y, 48, 48);
            destinationRec = new Rectangle((int)location.X + 48, (int)location.Y, 48, 48);
            destinationRec = new Rectangle((int)location.X - 36, (int)location.Y - 48, 48, 48);
            destinationRec = new Rectangle((int)location.X + 36, (int)location.Y - 48, 48, 48);
            destinationRec = new Rectangle((int)location.X - 36, (int)location.Y + 48, 48, 48);
            destinationRec = new Rectangle((int)location.X + 36, (int)location.Y + 48, 48, 48);
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor, 0, new Vector2(0,0), myEffect, 0);
            mySpriteBatch.End();
        }


    }
}
