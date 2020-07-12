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
        public HudFrame(Game1 myGame)
        { 

            _link = myGame.link;
            //width = w;
            //height = h;
        }
        public void Draw(int x, int y)
        {
            Vector2 location = new Vector2(x, y);
            frame.Draw(location,false);

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
