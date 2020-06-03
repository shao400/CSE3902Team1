﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class LinkNoneMovingLeftSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        
        public void Update()
        {
            frame++;
            if (frame == 2)
            {
                frame = 0;
            }
            switch (frame)
            {
                case 1:
                    sourceRec = new Rectangle(35, 11, 16, 16);
                    
                    break;
                case 2:
                    sourceRec = new Rectangle(52, 11, 16, 16);
                    break;
                default:
                    break;
            }

        }
        public void Draw(Vector2 location)
        {
            SpriteEffects effect = SpriteEffects.FlipHorizontally;
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 48, 48), sourceRec, myColor, 0, location, effect, 0);
            mySpriteBatch.End();

        }
        public void LoadContent(SpriteBatch spriteBatch, Texture2D texture)
        {
            mySpriteBatch = spriteBatch;
            myTexture = texture;
        }
    }
}