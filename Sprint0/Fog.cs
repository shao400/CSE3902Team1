using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0.xml;
using Microsoft.Xna.Framework.Content;
using Sprint0.UtilityClass;
using Sprint0.Player;

namespace Sprint0.GameStates
{
    class Fog
    {
        private Player1 myplayer;
        private Vector2 location;
        private ISprite mySprite;

        public Fog(Player1 link)
        {
            myplayer = link;
            mySprite = new FogSprite();
        }

        public void GetPlayerLoction()
        {
            location = new Vector2(myplayer.GetRectangle().X, myplayer.GetRectangle().Y);
        }

        public void Draw()
        {
            mySprite.Draw(location,false);
        }

        public void Update()
        {
            GetPlayerLoction();
        }

    }
}
