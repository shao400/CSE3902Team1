using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.UtilityClass;

namespace Sprint0.Sprite
{
    public class ItemTriforceSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        

        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if(frame < IntegerHolder.Ten)
            {
                sourceRec = new Rectangle(275, IntegerHolder.Three, IntegerHolder.Ten, IntegerHolder.Ten);
            } 
            else if(frame >IntegerHolder.Ten)
            {
                sourceRec = new Rectangle(275, 19, IntegerHolder.Ten, IntegerHolder.Ten);
            }
         }

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, bool isDamaged)
        {
            Rectangle destinationRec = new Rectangle((int)location.X, (int)location.Y, IntegerHolder.Thirty, IntegerHolder.Thirty);
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
