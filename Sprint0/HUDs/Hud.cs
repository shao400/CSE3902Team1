using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.UtilityClass;
namespace Sprint0.HUDs
{
    public class Hud : IHud
    {
        private HealthBar Hpbar;
        private WeaponSlot WpSlot;
        public HudMap map;
        private HudFrame frame;
        private ItemSlot itemSlot;
        Player1 _link;

        public Hud(Game1 myGame)
        { 
            _link = myGame.link;
            Hpbar = new HealthBar(myGame);
            WpSlot = new WeaponSlot(myGame);
            map = new HudMap(myGame);
            itemSlot = new ItemSlot(myGame);
            frame = new HudFrame(myGame);
        }
        public void Draw(int x, int y)
        {
            frame.Draw(x, y);
            Hpbar.Draw(x + 529, y + 72);
            WpSlot.Draw(x + 460, y + 72);
            itemSlot.Draw(x+288 ,y+IntegerHolder.fourtyEight);
            map.Draw(x + 83, y + 118);
        }


    }
}
