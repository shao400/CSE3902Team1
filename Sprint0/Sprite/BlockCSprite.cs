using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class BlockCSprite : ISprite
    {
        //BlockA 323 59 16 16
        private static SpriteBatch spritebatch;
        private static Texture2D texture;
        Rectangle sourceRec = new Rectangle(323, 59, 16, 16);
        //Rectangle destinationRec = new Rectangle(250, 300, 64, 64);


        public void Update()
        {
            //static nothing to do
        }

        public void LoadContent(SpriteBatch batch, Texture2D f)
        {

            spritebatch = batch;
            texture = f;

        }

        public void Draw(Vector2 location, Boolean isDamaged)
        {
            Rectangle destinationRec = new Rectangle((int)location.X, (int)location.Y, 48, 48);
            spritebatch.Begin();
            spritebatch.Draw(texture, destinationRec, sourceRec, Color.White);
            spritebatch.End();
        }



    }
}
