using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using Sprint0.UtilityClass;
namespace Sprint0.HUDs
{
    public class ItemSlot : IHud
    {
        //List of Hud Sprites
        private HudXSprite X = SpriteFactory.HudX;
        private HudOneSprite One = SpriteFactory.HudOne;
        private HudTwoSprite Two = SpriteFactory.HudTwo;
        private HudThreeSprite Three = SpriteFactory.HudThree;
        private HudFourSprite Four = SpriteFactory.HudFour;
        private HudFiveSprite Five = SpriteFactory.HudFive;
        private HudSixSprite Six = SpriteFactory.HudSix;
        private HudSevenSprite Seven = SpriteFactory.HudSeven;
        private HudEightSprite Eight = SpriteFactory.HudEight;
        private HudNineSprite Nine = SpriteFactory.HudNine;
        private HudZeroSprite Zero = SpriteFactory.HudZero;

        private int health;
        private int dx = 25;
        Player1 _link;
        public ItemSlot(Game1 myGame)
        { 
            _link = myGame.link;
        }

        public void DrawRuppyC(int x, int y)
        {
            Vector2 locationR = new Vector2(x, y);
            int HundredC = _link.itemCount()[0] / IntegerHolder.OneOO;
            int remain = _link.itemCount()[0] % IntegerHolder.OneOO;
            switch (HundredC) {
                case 0:
                    Zero.Draw(locationR, false);
                    break;
                case 1:
                    One.Draw(locationR, false);
                    break;
                case 2:
                    Two.Draw(locationR, false);
                    break;
                case IntegerHolder.Three:
                    Three.Draw(locationR, false);
                    break;
                case IntegerHolder.Four:
                    Four.Draw(locationR, false);
                    break;
                case IntegerHolder.Five:
                    Five.Draw(locationR, false);
                    break;
                case IntegerHolder.Six:
                    Six.Draw(locationR, false);
                    break;
                case IntegerHolder.Seven:
                    Seven.Draw(locationR, false);
                    break;
                case IntegerHolder.Eight:
                    Eight.Draw(locationR, false);
                    break;
                case IntegerHolder.Nine:
                    Nine.Draw(locationR, false);
                    break;
            }
            int TenC = remain / IntegerHolder.Ten;
            remain = remain % IntegerHolder.Ten;
            locationR.X += dx;
            switch (TenC)
            {
                case 0:
                    Zero.Draw(locationR, false);
                    break;
                case 1:
                    One.Draw(locationR, false);
                    break;
                case 2:
                    Two.Draw(locationR, false);
                    break;
                case IntegerHolder.Three:
                    Three.Draw(locationR, false);
                    break;
                case IntegerHolder.Four:
                    Four.Draw(locationR, false);
                    break;
                case IntegerHolder.Five:
                    Five.Draw(locationR, false);
                    break;
                case IntegerHolder.Six:
                    Six.Draw(locationR, false);
                    break;
                case IntegerHolder.Seven:
                    Seven.Draw(locationR, false);
                    break;
                case IntegerHolder.Eight:
                    Eight.Draw(locationR, false);
                    break;
                case IntegerHolder.Nine:
                    Nine.Draw(locationR, false);
                    break;
            }
            int DigitC = remain;
            locationR.X += dx;
            switch (DigitC)
            {
                case 0:
                    Zero.Draw(locationR, false);
                    break;
                case 1:
                    One.Draw(locationR, false);
                    break;
                case 2:
                    Two.Draw(locationR, false);
                    break;
                case IntegerHolder.Three:
                    Three.Draw(locationR, false);
                    break;
                case IntegerHolder.Four:
                    Four.Draw(locationR, false);
                    break;
                case IntegerHolder.Five:
                    Five.Draw(locationR, false);
                    break;
                case IntegerHolder.Six:
                    Six.Draw(locationR, false);
                    break;
                case IntegerHolder.Seven:
                    Seven.Draw(locationR, false);
                    break;
                case IntegerHolder.Eight:
                    Eight.Draw(locationR, false);
                    break;
                case IntegerHolder.Nine:
                    Nine.Draw(locationR, false);
                    break;
            }
        }

        public void DrawKeyBombC(int x, int y,int C)
        {
            Vector2 locationKB = new Vector2(x, y);
            X.Draw(locationKB,false);
            locationKB.X += dx;
            int TenC = _link.itemCount()[C] / IntegerHolder.Ten;
            int remain = _link.itemCount()[C] % IntegerHolder.Ten;
            switch (TenC)
            {
                case 0:
                    Zero.Draw(locationKB, false);
                    break;
                case 1:
                    One.Draw(locationKB, false);
                    break;
                case 2:
                    Two.Draw(locationKB, false);
                    break;
                case IntegerHolder.Three:
                    Three.Draw(locationKB, false);
                    break;
                case IntegerHolder.Four:
                    Four.Draw(locationKB, false);
                    break;
                case IntegerHolder.Five:
                    Five.Draw(locationKB, false);
                    break;
                case IntegerHolder.Six:
                    Six.Draw(locationKB, false);
                    break;
                case IntegerHolder.Seven:
                    Seven.Draw(locationKB, false);
                    break;
                case IntegerHolder.Eight:
                    Eight.Draw(locationKB, false);
                    break;
                case IntegerHolder.Nine:
                    Nine.Draw(locationKB, false);
                    break;
            }
            int DigitC = remain;
            locationKB.X += dx;
            switch (DigitC)
            {
                case 0:
                    Zero.Draw(locationKB, false);
                    break;
                case 1:
                    One.Draw(locationKB, false);
                    break;
                case 2:
                    Two.Draw(locationKB, false);
                    break;
                case IntegerHolder.Three:
                    Three.Draw(locationKB, false);
                    break;
                case IntegerHolder.Four:
                    Four.Draw(locationKB, false);
                    break;
                case IntegerHolder.Five:
                    Five.Draw(locationKB, false);
                    break;
                case IntegerHolder.Six:
                    Six.Draw(locationKB, false);
                    break;
                case IntegerHolder.Seven:
                    Seven.Draw(locationKB, false);
                    break;
                case IntegerHolder.Eight:
                    Eight.Draw(locationKB, false);
                    break;
                case IntegerHolder.Nine:
                    Nine.Draw(locationKB, false);
                    break;
            }
        
        }

        public void Draw(int x, int y)
        {
            const int dy1 = IntegerHolder.fourtyEight;
            const int dy2 = 24;
            DrawRuppyC(x, y);
            DrawKeyBombC(x, y+dy1,1 );
            DrawKeyBombC(x, y+dy1+dy2,2);
        }

        public void GetLinkHp()
        {
            //not used yet
            health = _link.linkHp();
        }

    }
}
