using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class DoorTopSprite : ISprite
    {
        private static SpriteBatch spritebatch;
        private static Texture2D texture;
        Rectangle sourceRec = new Rectangle(848, 11, 32, 17);
        

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
            Rectangle destinationRec = new Rectangle((int)location.X, (int)location.Y, 32, 17);
            spritebatch.Begin();
            spritebatch.Draw(texture, destinationRec, sourceRec, Color.White);
            spritebatch.End();

        }


    }
}

