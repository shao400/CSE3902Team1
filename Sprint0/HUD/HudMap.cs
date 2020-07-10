using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using System.Collections.Generic;

namespace Sprint0.HUD
{
    public class HudMap : IHud
    {
        private HudMapPieceSprite room = SpriteFactory.HudMapPiece;     
        private HudPointSprite point = SpriteFactory.HudPoint;
        private int xAix;
        private int yAix;
        private int currentRoom;
        Game1 _myGame;
        private const int dx = 33;
        private const int dy = 15;
        private List<int> discovered;
        //private int width;
        //private int height;
        public HudMap(int x, int y, Game1 myGame)
        { 
            xAix = x;
            yAix = y;
            _myGame = myGame;
            discovered = new List<int>();
            //width = w;
            //height = h;
        }
        private void staticMapDraw()            
        {
            //position trans logic still need change
            discovered.Add(_myGame.currentRoom.roomID);

            Vector2 location = new Vector2(xAix, yAix);
            if (discovered.Contains(0)) {
                room.Draw(location, false);
            }

            if (discovered.Contains(1))
            {
                location.X += dx;
                room.Draw(location, false);
            }

            if (discovered.Contains(2))
            {
                location.X += dx;
                room.Draw(location, false);
            }

            if (discovered.Contains(3))
            {
                location.X -= dx;
                location.Y -= dy;
                room.Draw(location, false);
            }


        }
        public void Draw()
        {           
            //position trans logic still need change
            Vector2 locationP = new Vector2(xAix+16, yAix+7);          
            staticMapDraw();
            if (_myGame.currentRoom.roomID==0) { 
                
                    point.Draw(locationP, false);                 
            }else if (_myGame.currentRoom.roomID == 1)
            {
                locationP.X += dx;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 2)
            {
                locationP.X += dx*2;
                point.Draw(locationP, false);
            }
        }

      


        public void Update()
        {

        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(xAix, yAix, 32, 32);
        }
    }
}
