using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;

namespace Sprint0.HUD
{
    public class HudMap : IHud
    {
        private HudMapPieceSprite room1 = SpriteFactory.HudMapPiece;
        private HudMapPieceSprite room2 = SpriteFactory.HudMapPiece;
        private HudMapPieceSprite room3 = SpriteFactory.HudMapPiece;
        private HudPointSprite point = SpriteFactory.HudPoint;
        private int xAix;
        private int yAix;
        private int currentRoom;
        Game1 _myGame;
        //private int width;
        //private int height;
        public HudMap(int x, int y, Game1 myGame)
        { 
            xAix = x;
            yAix = y;
            _myGame = myGame;
            //width = w;
            //height = h;
        }

        public void GetCurrentRoom()
        {
            //not used yet
            currentRoom = _myGame.roomCount;
        }
        public void Draw()
        {
            Vector2 location = new Vector2(xAix, yAix);
            Vector2 locationP = new Vector2(xAix+16, yAix+7);
            //Vector2 locationP2 = new Vector2(xAix+49, yAix+7);
            //Vector2 locationP3 = new Vector2(xAix + 49, yAix - 8);
            room1.Draw(location,false);
            location.X += 33;            
            room2.Draw(location,false);
            location.Y -= 15;
            room3.Draw(location,false);
            if (_myGame.currentRoom.roomID==0) { 
                
                    point.Draw(locationP, false);                 
            }else if (_myGame.currentRoom.roomID == 1)
            {
                locationP.X += 33;
                point.Draw(locationP, false);
            }
            else if (_myGame.currentRoom.roomID == 2)
            {
                locationP.X += 33;
                locationP.Y -= 15;
                point.Draw(locationP, false);locationP.X += 33;
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
