﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class LinkMagicalSStandingUpSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Rectangle sourceRec = new Rectangle(204, 97, 16, 28);
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
            if (isDamaged)
            {
                myColor = Color.GreenYellow;
            }
            else
            {
                myColor = Color.CornflowerBlue;
            }
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y-36, 48, 84), sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}