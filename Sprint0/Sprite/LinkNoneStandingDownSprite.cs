using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatformDesktopProject.Sprite
{
    public class LinkNoneStandingDownSprite: Interface.ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Rectangle sourceRec = new Rectangle(125, 0, 48, 86);
        Color myColor = Color.CornflowerBlue;
        public void Update() 
        {

        }
        public void Draw(Rectangle destinationRec)
        {
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec,sourceRec,myColor);
            mySpriteBatch.End();

        }
        public void LoadContent(SpriteBatch spriteBatch, Texture2D texture)
        {
            mySpriteBatch = spriteBatch;
            myTexture = texture;
        }
    }
}
