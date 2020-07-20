using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Sprite;
using System.Collections.Generic;

namespace Sprint0.HUDs
{
    public class HudMap : IHud
    {
        private HudMapPieceSprite room = SpriteFactory.HudMapPiece;     
        private HudPointSprite point = SpriteFactory.HudPoint;
        Game1 _myGame;
        private const int dx = 31;
        private const int dy = 14;
        private List<int> discovered;

        public HudMap(Game1 myGame)
        { 
            _myGame = myGame;
            discovered = new List<int>();
        }
        private void staticMapDraw(int xAix, int yAix)
        {
            //position trans logic still need change
            discovered.Add(_myGame.currentRoom.roomID);
            Vector2 location = new Vector2(xAix, yAix);
            Vector2 restore = new Vector2(xAix, yAix);
            if (discovered.Contains(0)) {
                room.Draw(location, false);
            }
            if (discovered.Contains(1))
            {
                location.X += dx;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(2))
            {
                location.X += 2 * dx;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(3))
            {
                location.X += dx;
                location.Y -= dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(4))
            {
                location.Y -= 2 * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(5))
            {
                location.X += dx;
                location.Y -= 2 * dy;          
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(6))
            {
                location.X += 2 * dx;
                location.Y -= 2 * dy;             
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(7))
            {
                location.X -= dx;
                location.Y -= 3 * dy;             
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(8))
            {
                location.Y -= 3 * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(9))
            {
                location.X += dx;
                location.Y -= 3 * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(10))
            {
                location.X += 2*dx;
                location.Y -= 3 * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(11))
            {
                location.X += 3*dx;
                location.Y -= 3 * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(12))
            {
                location.X += dx;
                location.Y -= 4 * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(13))
            {
                location.X += 3*dx;
                location.Y -= 4 * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(14))
            {
                location.X += 4*dx;
                location.Y -= 4 * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(15))
            {
                location.Y -= 5 * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(16))
            {
                location.X += dx;
                location.Y -= 5 * dy;
                room.Draw(location, false);
                location = restore;
            }

        }
        public void Draw(int x, int y)
        {           
            //position trans logic still need change
            Vector2 locationP = new Vector2(x+16, y+7);       
            if(_myGame.link.HaveMapOrCompass()[0] == true) staticMapDraw(x, y);

            if (_myGame.currentRoom.roomID==0) { 
                
                    point.Draw(locationP, false);                 
            }else if (_myGame.currentRoom.roomID == 1)
            {
                locationP.X += dx;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 2)
            {
                locationP.X += 2*dx;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 3)
            {
                locationP.X += dx;
                locationP.Y -= dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 4)
            {
                locationP.Y -= 2*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 5)
            {
                locationP.X += dx;
                locationP.Y -= 2*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 6)
            {
                locationP.X += 2*dx;
                locationP.Y -= 2*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 7)
            {
                locationP.X -= dx;
                locationP.Y -= 3*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 8)
            {
                locationP.Y -= 3*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 9)
            {
                locationP.X += dx;
                locationP.Y -= 3*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 10)
            {
                locationP.X += 2*dx;
                locationP.Y -= 3 * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 11)
            {
                locationP.X += 3*dx;
                locationP.Y -= 3 * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 12)
            {
                locationP.X += dx;
                locationP.Y -= 4 * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID ==13)
            {
                locationP.X += 3*dx;
                locationP.Y -= 4 * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 14)
            {
                locationP.X += 4 * dx;
                locationP.Y -= 4 * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 15)
            {
                locationP.Y -= 5 * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 16)
            {
                locationP.X += dx;
                locationP.Y -= 5 * dy;
                point.Draw(locationP, false);
            }
            Vector2 locationTarget = new Vector2(x,y-5*dy);
            if (_myGame.link.HaveMapOrCompass()[1]) point.Draw(locationTarget,false);
        }
     
        public void Update()
        {

        }

        public Rectangle GetRectangle(int x, int y)
        {
            return new Rectangle(x, y, 32, 32);
        }
    }
}
