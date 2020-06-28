using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{
    public class LinkMagicalSAttackingRightSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        int shownFrame = 0;
        public void Update()
        {
            frame++;
            if (frame == 16)
            {
                frame = 0;
            }
            if (frame < 4)
            {
                shownFrame = 0;
            }
            else if (frame < 8)
            {
                shownFrame = 1;
            }
            else if (frame < 12)
            {
                shownFrame = 2;
            }
            else
            {
                shownFrame = 3;
            }
            
            switch (shownFrame)
            {
                case 0:
                    sourceRec = new Rectangle(187, 77, 16, 16);
                    break;
                case 1:
                    sourceRec = new Rectangle(204, 77, 27, 17);
                    break;
                case 2:
                    sourceRec = new Rectangle(232, 77, 23, 17);
                    break;
                case 3:
                    sourceRec = new Rectangle(256, 77, 19, 17);
                    break;
                default:
                    break;
            }
        }
        public void Draw(Vector2 location, Boolean isDamaged)
        {
            if (isDamaged)
            {
                myColor = Color.GreenYellow;
            }
            else
            {
                myColor = Color.CornflowerBlue;
            }

            mySpriteBatch.Begin();
            switch (sourceRec.Width)
            {
                case 16:
                    mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 48, 48), sourceRec, myColor);
                    break;
                case 27:
                    mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 84, 51), sourceRec, myColor);
                    break;
                case 23:
                    mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 69, 51), sourceRec, myColor);
                    break;
                case 19:
                    mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 57, 51), sourceRec, myColor);
                    break;
                default:
                    break;
            }
            mySpriteBatch.End();

        }
        public void LoadContent(SpriteBatch spriteBatch, Texture2D texture)
        {
            mySpriteBatch = spriteBatch;
            myTexture = texture;
        }
    }
}
