using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{ 
    public class LinkWhiteStandingDownSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Rectangle sourceRec = new Rectangle(111, 47, 16, 27);
        Color myColor = Color.CornflowerBlue;
        public void Update() 
        {

        }
        public void Draw(Vector2 location, Boolean isDamaged)
        {
            if (isDamaged) myColor = Color.GreenYellow;
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 48, 81), sourceRec, myColor);
            mySpriteBatch.End();

        }
        public void LoadContent(SpriteBatch spriteBatch, Texture2D texture)
        {
            mySpriteBatch = spriteBatch;
            myTexture = texture;
        }
    }
}
