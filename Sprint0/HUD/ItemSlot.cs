using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using System.Globalization;

namespace Sprint0.HUD
{
    public class ItemSlot : IHud
    {
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
        private int xAix;
        private int yAix;
        private int health;
        private int dx = 25;
        Player1 _link;
        //private int width;
        //private int height;
        public ItemSlot(Game1 myGame)
        { 
            _link = myGame.link;
            //width = w;
            //height = h;
        }

        public void DrawRuppyC(int x, int y)
        {
            Vector2 locationR = new Vector2(x, y);
            int HundredC = _link.itemCount()[0] / 100;
            int remain = _link.itemCount()[0] % 100;
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
                case 3:
                    Three.Draw(locationR, false);
                    break;
                case 4:
                    Four.Draw(locationR, false);
                    break;
                case 5:
                    Five.Draw(locationR, false);
                    break;
                case 6:
                    Six.Draw(locationR, false);
                    break;
                case 7:
                    Seven.Draw(locationR, false);
                    break;
                case 8:
                    Eight.Draw(locationR, false);
                    break;
                case 9:
                    Nine.Draw(locationR, false);
                    break;
            }
            int TenC = remain / 10;
            remain = remain % 10;
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
                case 3:
                    Three.Draw(locationR, false);
                    break;
                case 4:
                    Four.Draw(locationR, false);
                    break;
                case 5:
                    Five.Draw(locationR, false);
                    break;
                case 6:
                    Six.Draw(locationR, false);
                    break;
                case 7:
                    Seven.Draw(locationR, false);
                    break;
                case 8:
                    Eight.Draw(locationR, false);
                    break;
                case 9:
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
                case 3:
                    Three.Draw(locationR, false);
                    break;
                case 4:
                    Four.Draw(locationR, false);
                    break;
                case 5:
                    Five.Draw(locationR, false);
                    break;
                case 6:
                    Six.Draw(locationR, false);
                    break;
                case 7:
                    Seven.Draw(locationR, false);
                    break;
                case 8:
                    Eight.Draw(locationR, false);
                    break;
                case 9:
                    Nine.Draw(locationR, false);
                    break;
            }
        }

        public void DrawKeyBombC(int x, int y,int C)
        {
            Vector2 locationKB = new Vector2(x, y);
            X.Draw(locationKB,false);
            locationKB.X += dx;
            int TenC = _link.itemCount()[C] / 10;
            int remain = _link.itemCount()[C] % 10;
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
                case 3:
                    Three.Draw(locationKB, false);
                    break;
                case 4:
                    Four.Draw(locationKB, false);
                    break;
                case 5:
                    Five.Draw(locationKB, false);
                    break;
                case 6:
                    Six.Draw(locationKB, false);
                    break;
                case 7:
                    Seven.Draw(locationKB, false);
                    break;
                case 8:
                    Eight.Draw(locationKB, false);
                    break;
                case 9:
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
                case 3:
                    Three.Draw(locationKB, false);
                    break;
                case 4:
                    Four.Draw(locationKB, false);
                    break;
                case 5:
                    Five.Draw(locationKB, false);
                    break;
                case 6:
                    Six.Draw(locationKB, false);
                    break;
                case 7:
                    Seven.Draw(locationKB, false);
                    break;
                case 8:
                    Eight.Draw(locationKB, false);
                    break;
                case 9:
                    Nine.Draw(locationKB, false);
                    break;
            }
        
        }

        public void Draw(int x, int y)
        {
            const int dy1 = 48;
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


        public void Update()
        {

        }

        public Rectangle GetRectangle(int x, int y)
        {
            return new Rectangle(x, y, 32, 32);
        }
    }
}
