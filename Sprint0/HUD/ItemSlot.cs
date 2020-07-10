using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;

namespace Sprint0.HUD
{
    public class ItemSlot : IHud
    {
        private HudEmptyHeartSprite empty = SpriteFactory.HudEmptyHeart;
        private HudHalfHeartSprite half = SpriteFactory.HudHalfHeart;
        private ItemHeartContainerSprite solid = SpriteFactory.ItemHeartContainer;
        private int xAix;
        private int yAix;
        private int health;
        Player1 _link;
        //private int width;
        //private int height;
        public ItemSlot(int x, int y, Player1 link)
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
            if (_link.linkHp() == 2)
            {
                solid.Draw(location, false);
            }
            else if (_link.linkHp() == 1)
            {
                half.Draw(location, false);
            }
            else if (_link.linkHp() == 0)
            {
                empty.Draw(location, false);
            }

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
