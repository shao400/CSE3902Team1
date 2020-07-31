using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.UtilityClass;
using Sprint0.Player;

namespace Sprint0
{
    public class LinkNoneMovingDownSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.GreenYellow;
        Rectangle sourceRec;
        int frame = 0;
        int shownFrame = 0;
        public void Update()
        {
            shownFrame++;
            if (shownFrame == 20)
            {
                shownFrame = 0;
            }
            if (shownFrame < IntegerHolder.Ten)
            {
                frame = 0;
            }
            else if (shownFrame < 20)
            {
                frame = 1;
            }

            switch (frame) { 
                case 0:
                    sourceRec = new Rectangle(1, 11, 16, 16);
                    break;
                case 1:
                    sourceRec = new Rectangle(18, 11, 16, 16);
                    break;
                default:
                    break;
            }

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
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive), sourceRec, myColor);
            mySpriteBatch.End();

        }
        public void LoadContent(SpriteBatch spriteBatch, Texture2D texture)
        {
            mySpriteBatch = spriteBatch;
            myTexture = texture;
        }
        public static bool isChangeColor(Player1 link)
        {
            return link.isChangeColor;
        }
    }
}
