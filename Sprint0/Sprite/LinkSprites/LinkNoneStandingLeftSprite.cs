using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class LinkNoneStandingLeftSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Rectangle sourceRec = new Rectangle(35, 11, 16, 16);
        Color myColor = Color.GreenYellow;
        public void Update()
        {

        }
        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }
        public void Draw(Vector2 location, Boolean isDamaged)
        {
            if (isDamaged)
            {
                myColor = Color.Red;
            }
            else
            {
                myColor = Color.GreenYellow;
            }
            SpriteEffects effect = SpriteEffects.FlipHorizontally;
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 45, 45), sourceRec,  myColor, 0, new Vector2(0,0), effect, 0);
            mySpriteBatch.End();
        }
    }
}
