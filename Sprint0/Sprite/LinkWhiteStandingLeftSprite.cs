using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class LinkWhiteStandingLeftSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Rectangle sourceRec = new Rectangle(111, 77, 27, 17);
        Color myColor = Color.CornflowerBlue;
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
            if (isDamaged) myColor = Color.GreenYellow;
            SpriteEffects effect = SpriteEffects.FlipHorizontally;
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X-36, (int)location.Y, 84, 51), sourceRec, myColor, 0, new Vector2(0, 0), effect, 0);
            mySpriteBatch.End();
        }
    }
}
