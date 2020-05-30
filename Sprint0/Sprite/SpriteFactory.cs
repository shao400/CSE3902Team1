using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Controller;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
//Author: Gengyi Qin
namespace Sprint0.Sprite
{
    public static class SpriteFactory
    {
        //TO-DO:Initialize all kinds of sprite objects in according methods

        public static void LoadContent(SpriteBatch batch, ContentManager content)
        {
            LoadLinkContent(batch, content);
            LoadItemContent(batch, content);
            LoadEnemyContent(batch, content);
        }

        private static void LoadLinkContent(SpriteBatch batch, ContentManager content)
        {

        }

        private static void LoadItemContent(SpriteBatch batch, ContentManager content)
        {

        }
        
        private static void LoadEnemyContent(SpriteBatch batch, ContentManager content)
        {

        }

    }
}
