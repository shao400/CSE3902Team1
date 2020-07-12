using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;

namespace Sprint0.HUD
{
    public class HealthBar : IHud
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
        public HealthBar(Game1 myGame)
        {

            _link = myGame.link;
            //width = w;
            //height = h;
        }
        public void Draw(int x, int y)
        {
            Vector2 location = new Vector2(x, y);
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
        public Rectangle GetRectangle(int x, int y)
        {
            return new Rectangle(x, y, 32, 32);
        }
    }
}
