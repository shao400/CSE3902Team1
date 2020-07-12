using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;

namespace Sprint0.HUD
{
    public class WeaponSlot : IHud
    {
        private HudEmptyHeartSprite empty = SpriteFactory.HudEmptyHeart;
        private HudHalfHeartSprite half = SpriteFactory.HudHalfHeart;
        private ItemHeartContainerSprite solid = SpriteFactory.ItemHeartContainer;
        private ItemWoodenSwordSprite woodenSword = SpriteFactory.ItemWoodenSword;
        private int xAix;
        private int yAix;
        private string weapon;
        Player1 _link;
        //private int width;
        //private int height;
        public WeaponSlot(int x, int y, Game1 myGame)
        { 
            xAix = x;
            yAix = y;
            _link = myGame.link;
            weapon = "";
            //width = w;
            //height = h;
        }
        public void Draw()
        {
            //None, WoodenSword, WhiteSword, MagicalSword, MagicalRod
            Vector2 location = new Vector2(xAix, yAix);
            //System.Diagnostics.Debug.WriteLine(_link.states.GetCurrentWeapon());
            woodenSword.Draw(location, false);
            if (_link.GetCurrentWeapon().Equals("None", System.StringComparison.Ordinal))
            {
                woodenSword.Draw(location, false);
            }
            else if (_link.GetCurrentWeapon().Equals("WoodenSword", System.StringComparison.Ordinal))
            {
                half.Draw(location, false);
            }
            else if (_link.GetCurrentWeapon().Equals("WhiteSword", System.StringComparison.Ordinal))
            {
                solid.Draw(location, false);
            }else if (_link.GetCurrentWeapon().Equals("MagicalSword", System.StringComparison.Ordinal))
            {
                solid.Draw(location, false);
            }
            else if (_link.GetCurrentWeapon().Equals("MagicalRod", System.StringComparison.Ordinal))
            {
                solid.Draw(location, false);
            }

        }

        public void GetLinkItem()
        {
            //weapon = _link.states.GetCurrentWeapon();        
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
