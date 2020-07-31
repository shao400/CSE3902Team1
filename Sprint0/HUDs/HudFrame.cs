using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;

namespace Sprint0.HUDs
{
    public class HudFrame : IHud
    {
        private HudFrameSprite frame = SpriteFactory.HudFrame;
        Player1 _link;
        public HudFrame(Game1 myGame)
        { 
            _link = myGame.link;
        }
        public void Draw(int x, int y)
        {
            Vector2 location = new Vector2(x, y);
            frame.Draw(location,false);

        }

    }
}
