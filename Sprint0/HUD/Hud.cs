using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;

namespace Sprint0.HUD
{
    public class Hud : IHud
    {
        private HealthBar Hpbar;
        private WeaponSlot WpSlot;
        private HudMap map;
        private HudFrame frame;
        private int xAix;
        private int yAix;
        private int health;
        Player1 _link;
        //private int width;
        //private int height;
        public Hud(int x, int y, Game1 myGame)
        { 
            xAix = x;
            yAix = y;
            _link = myGame.link;
            Hpbar = new HealthBar(x+528, y+120, myGame);
            WpSlot = new WeaponSlot(x+460, y+72, myGame);
            map = new HudMap(x+83, y+118, myGame);
            frame = new HudFrame(x, y, myGame);
            //width = w;
            //height = h;
        }
        public void Draw()
        {
            frame.Draw();
            Hpbar.Draw();
            WpSlot.Draw();
            map.Draw();

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
