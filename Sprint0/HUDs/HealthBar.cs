using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using Sprint0.UtilityClass;

namespace Sprint0.HUDs
{
    public class HealthBar : IHud
    {
        private HudEmptyHeartSprite empty = SpriteFactory.HudEmptyHeart;
        private HudHalfHeartSprite half = SpriteFactory.HudHalfHeart;
        private HudHeartSprite solid = SpriteFactory.HudHeart;
        private HudCoverSprite cover = SpriteFactory.HudCover;
        Player1 _link;
        private const int dx = 25;


        public HealthBar(Game1 myGame)
        {
            _link = myGame.link;         
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
            const int Max2H = 1;
            const int Max3H = 2;
            const int Max4H = IntegerHolder.Three;
            const int Max5H = IntegerHolder.Four;
            const int Max6H = IntegerHolder.Five;
            const int Max7H = IntegerHolder.Six;
            const int Max8H = IntegerHolder.Seven;

            Vector2 location = new Vector2(x, y);
            cover.Draw(location,false);
            location.Y +=dx;
            if (_link.linkHp() <= 2)
            {          
                if (_link.linkHp() == 1) half.Draw(location, false);             
                else if (_link.linkHp() == 2) solid.Draw(location, false);
              
                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp()-2) / 2);
            }else if (_link.linkHp() >2 * Max2H && _link.linkHp()<= 2 * Max2H + 2)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, Max2H);
                location.X += Max2H * dx;

                if (_link.linkHp() == 2 * Max2H + 1) half.Draw(location, false);
                else if (_link.linkHp() == 2 * Max2H + 2) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 2 * Max2H - 2) / 2);
            }
            else if (_link.linkHp() > 2 * Max3H && _link.linkHp() <= 2 * Max3H + 2)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, Max3H);
                location.X += Max3H * dx;

                if (_link.linkHp() == 2 * Max3H + 1) half.Draw(location, false);
                else if (_link.linkHp() == 2 * Max3H + 2) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 2 * Max3H - 2) / 2);
            }
            else if (_link.linkHp() > 2 * Max4H && _link.linkHp() <= 2 * Max4H + 2)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, Max4H);
                location.X += Max4H * dx;

                if (_link.linkHp() == 2 * Max4H + 1) half.Draw(location, false);
                else if (_link.linkHp() == 2 * Max4H + 2) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 2 * Max4H - 2) / 2);
            }
            else if (_link.linkHp() > 2 * Max5H && _link.linkHp() <= 2 * Max5H + 2)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, Max5H);
                location.X += Max5H * dx;

                if (_link.linkHp() == 2 * Max5H + 1) half.Draw(location, false);
                else if (_link.linkHp() == 2 * Max5H + 2) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 2 * Max5H - 2) / 2);
            }
            else if (_link.linkHp() > 2*Max6H && _link.linkHp() <= 2 * Max6H + 2)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, Max6H);
                location.X += Max6H * dx;

                if (_link.linkHp() == 2 * Max6H + 1) half.Draw(location, false);
                else if (_link.linkHp() == 2 * Max6H + 2) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 2 * Max6H - 2) / 2);
            }
            else if (_link.linkHp() > 2 * Max7H && _link.linkHp() <= 2 * Max7H + 2)
            {
                DrawMultiSolid((int)location.X, (int)location.Y, Max7H);
                location.X += Max7H * dx;

                if (_link.linkHp() == 2 * Max7H + 1) half.Draw(location, false);
                else if (_link.linkHp() == 2 * Max7H + 2) solid.Draw(location, false);

                location.X += dx;
                DrawMultiEmpty((int)location.X, (int)location.Y, (_link.linkMaxHp() - 2 * Max7H - 2) / 2);
            }
            else if (_link.linkHp() > 2 * Max8H && _link.linkHp() <= 2 * Max8H + 2)
            {
                DrawMultiSolid((int)location.X, (int)location.Y,  Max8H);
                location.X += Max8H * dx;

                if (_link.linkHp() == 2 * Max8H+1) half.Draw(location, false);
                else if (_link.linkHp() == 2 * Max8H+2) solid.Draw(location, false);

            }


        }

    }
}
