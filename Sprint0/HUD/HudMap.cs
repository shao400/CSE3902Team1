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
        private int xAix;
        private int yAix;
        private int health;
        Player1 _link;
        //private int width;
        //private int height;
        public HudMap(int x, int y, Player1 link)
        { 
            xAix = x;
            yAix = y;
            _link = link;
            //width = w;
            //height = h;
        }
        public void Draw()
        {
            Vector2 location = new Vector2(xAix, yAix);
            room1.Draw(location,false);
            location.X += 33;            
            room2.Draw(location,false);
            location.Y -= 15;
            room3.Draw(location,false);
        }

        public void GetLinkHp()
        {
            //not used yet
            health = _link.linkHp();
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
