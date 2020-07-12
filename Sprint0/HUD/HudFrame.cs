using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;

namespace Sprint0.HUD
{
    public class HudFrame : IHud
    {
        private HudFrameSprite frame = SpriteFactory.HudFrame;

        private int xAix;
        private int yAix;

        Player1 _link;
        //private int width;
        //private int height;
        public HudFrame(int x, int y, Game1 myGame)
        { 
            xAix = x;
            yAix = y;
            _link = myGame.link;
            //width = w;
            //height = h;
        }
        public void Draw()
        {
            Vector2 location = new Vector2(xAix, yAix);
            frame.Draw(location,false);

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
