using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
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
        private ItemHeartSprite solid = SpriteFactory.ItemHeart;
        private int xAix;
        private int yAix;
        private int health;
        //private int width;
        //private int height;
        public HealthBar(int x, int y)
        { 
            xAix = x;
            yAix = y;
            health = 2;
            //width = w;
            //height = h;
        }
        public void Draw()
        {
            Vector2 location = new Vector2(xAix, yAix); //test, change to xAix and yAix later
            if (health == 2)
            {
                solid.Draw(location, false);
            }
            else if (health == 1)
            {
                half.Draw(location, false);
            }
            else if (health == 0)
            {
                empty.Draw(location, false);
            }

        }

        public void Reduced()
        {
            if (health > 0)
            {
                health = health - 1;
            }
        }

        public void hud_reset()
        {
            health = 2;
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
