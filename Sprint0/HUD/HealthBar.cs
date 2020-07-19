using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using System.Runtime.CompilerServices;

namespace Sprint0.HUD
{
    public class HealthBar : IHud
    {
        private HudEmptyHeartSprite empty = SpriteFactory.HudEmptyHeart;
        private HudHalfHeartSprite half = SpriteFactory.HudHalfHeart;
        private HudHeartSprite solid = SpriteFactory.HudHeart;
        private HudCoverSprite cover = SpriteFactory.HudCover;
        private int xAix;
        private int yAix;
        private int health;
        Player1 _link;
        private const int dx = 25;
        //private int width;
        //private int height;
        public HealthBar(Game1 myGame)
        {

            _link = myGame.link;
            //width = w;
            //height = h;
        }

        private void DrawMultiEmpty(int x, int y ,int count)
        {
            Vector2 location = new Vector2(x, y);
            for (int i = 0;i<count;i++)
            {
                empty.Draw(location, false);
                location.X += dx;
            }
        }

        private void DrawMultiSolid(int x, int y, int count)
        {
            Vector2 location = new Vector2(x, y);
            for (int i = 0; i < count; i++)
            {
                solid.Draw(location, false);
                location.X += dx;
            }
        }
        public void Draw(int x, int y)
        {
            Vector2 location = new Vector2(x, y);
            cover.Draw(location,false);
            location.Y +=dx;
            if (_link.linkHp() <= 2)
            {          
                if (_link.linkHp() == 1) half.Draw(location, false);             
                else if (_link.linkHp() == 2) solid.Draw(location, false);
              
                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp()-2) / 2);
            }else if (_link.linkHp() >2 && _link.linkHp()<=4)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, 1);
                location.X += dx;

                if (_link.linkHp() == 3) half.Draw(location, false);            
                else if (_link.linkHp() == 4) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 4) / 2);
            }
            else if (_link.linkHp() > 4 && _link.linkHp() <= 6)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, 2);
                location.X += 2*dx;

                if (_link.linkHp() == 5) half.Draw(location, false);
                else if (_link.linkHp() == 6) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 6) / 2);
            }
            else if (_link.linkHp() > 6 && _link.linkHp() <= 8)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, 3);
                location.X += 3 * dx;

                if (_link.linkHp() == 7) half.Draw(location, false);
                else if (_link.linkHp() == 8) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 8) / 2);
            }
            else if (_link.linkHp() > 8 && _link.linkHp() <= 10)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, 4);
                location.X += 4 * dx;

                if (_link.linkHp() == 9) half.Draw(location, false);
                else if (_link.linkHp() == 10) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 10) / 2);
            }
            else if (_link.linkHp() > 10 && _link.linkHp() <= 12)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, 5);
                location.X += 5 * dx;

                if (_link.linkHp() == 11) half.Draw(location, false);
                else if (_link.linkHp() == 12) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 12) / 2);
            }
            else if (_link.linkHp() > 12 && _link.linkHp() <= 14)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, 6);
                location.X += 6 * dx;

                if (_link.linkHp() == 13) half.Draw(location, false);
                else if (_link.linkHp() == 14) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 14) / 2);
            }
            else if (_link.linkHp() > 14 && _link.linkHp() <= 16)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, 7);
                location.X += 7 * dx;

                if (_link.linkHp() == 15) half.Draw(location, false);
                else if (_link.linkHp() == 16) solid.Draw(location, false);

            }


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
