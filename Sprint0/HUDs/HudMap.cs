using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Sprite;
using System.Collections.Generic;
using Sprint0.UtilityClass;

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
            Vector2 restore = new Vector2(xAix ,yAix);
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
            if (discovered.Contains(IntegerHolder.Three))
            {
                location.X += dx;
                location.Y -= dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(IntegerHolder.Four))
            {
                location.Y -= 2 * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(IntegerHolder.Five))
            {
                location.X += dx;
                location.Y -= 2 * dy;          
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(IntegerHolder.Six))
            {
                location.X += 2 * dx;
                location.Y -= 2 * dy;             
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(IntegerHolder.Seven))
            {
                location.X -= dx;
                location.Y -= IntegerHolder.Three * dy;             
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(IntegerHolder.Eight))
            {
                location.Y -= IntegerHolder.Three * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(IntegerHolder.Nine))
            {
                location.X += dx;
                location.Y -= IntegerHolder.Three * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(IntegerHolder.Ten))
            {
                location.X += 2*dx;
                location.Y -= IntegerHolder.Three * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(11))
            {
                location.X += IntegerHolder.Three*dx;
                location.Y -= IntegerHolder.Three * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(12))
            {
                location.X += dx;
                location.Y -= IntegerHolder.Four * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(13))
            {
                location.X += IntegerHolder.Three*dx;
                location.Y -= IntegerHolder.Four * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(14))
            {
                location.X += IntegerHolder.Four*dx;
                location.Y -= IntegerHolder.Four * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(15))
            {
                location.Y -= IntegerHolder.Five * dy;
                room.Draw(location, false);
                location = restore;
            }
            if (discovered.Contains(16))
            {
                location.X += dx;
                location.Y -= IntegerHolder.Five * dy;
                room.Draw(location, false);
                location = restore;
            }

        }
        public void Draw(int x, int y)
        {
            //position trans logic still need change
            const int posModi1 = 16;
            const int posModi2 = IntegerHolder.Seven;
            const int posModi3 = IntegerHolder.Five;
            Vector2 locationP = new Vector2(x+posModi1, y+posModi2);       
            if(_myGame.link.HaveMapOrCompass()[0] == true) staticMapDraw(x+posModi3, y+posModi3);

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
            else if (_myGame.currentRoom.roomID == IntegerHolder.Three)
            {
                locationP.X += dx;
                locationP.Y -= dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == IntegerHolder.Four)
            {
                locationP.Y -= 2*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == IntegerHolder.Five)
            {
                locationP.X += dx;
                locationP.Y -= 2*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == IntegerHolder.Six)
            {
                locationP.X += 2*dx;
                locationP.Y -= 2*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == IntegerHolder.Seven)
            {
                locationP.X -= dx;
                locationP.Y -= IntegerHolder.Three*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == IntegerHolder.Eight)
            {
                locationP.Y -= IntegerHolder.Three*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == IntegerHolder.Nine)
            {
                locationP.X += dx;
                locationP.Y -= IntegerHolder.Three*dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == IntegerHolder.Ten)
            {
                locationP.X += 2*dx;
                locationP.Y -= IntegerHolder.Three * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 11)
            {
                locationP.X += IntegerHolder.Three*dx;
                locationP.Y -= IntegerHolder.Three * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 12)
            {
                locationP.X += dx;
                locationP.Y -= IntegerHolder.Four * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID ==13)
            {
                locationP.X += IntegerHolder.Three*dx;
                locationP.Y -= IntegerHolder.Four * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 14)
            {
                locationP.X += IntegerHolder.Four * dx;
                locationP.Y -= IntegerHolder.Four * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 15)
            {
                locationP.Y -= IntegerHolder.Five * dy;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 16)
            {
                locationP.X += dx;
                locationP.Y -= IntegerHolder.Five * dy;
                point.Draw(locationP, false);
            }
            Vector2 locationTarget = new Vector2(x+posModi1+IntegerHolder.Four*dx,y+posModi2-IntegerHolder.Four*dy);
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
