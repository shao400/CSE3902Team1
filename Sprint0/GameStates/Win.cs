using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Sprite;

namespace Sprint0.Block
{
    class Win : IGameState
    {
        private ISprite sprite = SpriteFactory.WinScreen;
        private int xpos;
        private int ypos;
        public Win(int x, int y)
        {
            xpos = x;
            ypos = y;
        }

        public void Draw()
        {
            Vector2 location = new Vector2(xpos, ypos);
            sprite.Draw(location, false);
        }

        public void Update()
        {
            //nothing to do here
        }

        public void loadNextRoom(int nextRoom)
        {
            // nothing
        }

    }
}