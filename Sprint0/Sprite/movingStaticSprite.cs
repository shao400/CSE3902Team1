using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class movingStaticSprite:ISprite
    {
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int SpriteX { get; set; }
        public int SpriteY { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;

        public movingStaticSprite(Texture2D texture, int rows, int columns)
        {
            Texture = texture;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = Rows * Columns;

            SpriteX = 400;
            SpriteY = 240;
        }

        public void Update()
        {
            SpriteY -= 1;
            if (SpriteY == 0)
            {
                SpriteY = 480 - Texture.Height / Rows;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle(SpriteX, SpriteY, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}