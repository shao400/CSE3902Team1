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
        private HudHeartSprite solid = SpriteFactory.HudHeart;
        private int xAix;
        private int yAix;
        private int health;
        Player1 _link;
        private const int dx= 25;
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
            if (_link.linkHp()<=2) { 
            if (_link.linkHp() == 0)
            {
                empty.Draw(location, false);
            }
            else if (_link.linkHp() == 1)
            {
                half.Draw(location, false);
            }
            else if (_link.linkHp() == 2)
            {
                solid.Draw(location, false);
            }
                location.X += dx;
                empty.Draw(location, false);
                location.X += dx;
                empty.Draw(location, false);
            }
            else if (_link.linkHp()>2&&_link.linkHp()<5)
            {
                solid.Draw(location, false);
                location.X += dx;
                if (_link.linkHp() == 3)
                {
                    half.Draw(location, false);
                }
                else if (_link.linkHp() == 4)
                {
                    solid.Draw(location, false);
                }
                location.X += dx;
                empty.Draw(location, false);
            }
            else if (_link.linkHp() >4)
            {
                solid.Draw(location, false);
                location.X += dx;
                solid.Draw(location, false);
                location.X += dx;
                if (_link.linkHp() == 5)
                {
                    half.Draw(location, false);
                }
                else if (_link.linkHp() == 6)
                {
                    solid.Draw(location, false);
                }

            }

        }



        public void Update()
        {

        }
        public Rectangle GetRectangle(int x, int y)
        {
            return new Rectangle(x, y, 24, 24);
        }
    }
}
