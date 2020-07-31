using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Sprint0.Sprite;
using Sprint0.HUDs;
using Sprint0.UtilityClass;
using Sprint0.Items;
using Sprint0.Player;
using Sprint0.Inventories;


namespace Sprint0.Inventories
{
    public class Handbook
    {       
        ISprite pickboxSprite = new PickBoxSprite();

        public int moveCountTot = 0;
        public int currentItem = 0;

        public Handbook()
        {
        }

        public void pickingIcon(int moveCount)
        {
            // Use N to pick icon
            Vector2 dest1 = new Vector2(238 + moveCountTot * IntegerHolder.Ninety, IntegerHolder.Ninety);
            Vector2 dest2 = new Vector2(240, 320);
            moveCountTot += moveCount;
            if (moveCountTot > IntegerHolder.Three)
            {
                dest1 = new Vector2(-120 + moveCountTot * IntegerHolder.Ninety, 153);
            }
            if (moveCountTot > IntegerHolder.Seven)
            {
                moveCountTot = 0;
                dest1 = new Vector2(238 + moveCountTot * IntegerHolder.Ninety, IntegerHolder.Ninety);
            }
            pickboxSprite.Draw(dest1, false);
            drawInfo(moveCountTot).Draw(dest2, false);
        }

        public static ISprite drawInfo(int index)
        {
            ISprite enemyInfoSprite = null;
            switch (index)
            {
                case 0:
                    enemyInfoSprite = new InfoGoriyaSprite();
                    break;
                case 1:
                    enemyInfoSprite = new InfoRopeSprite();
                    break;
                case 2:
                    enemyInfoSprite = new InfoStalfosSprite();
                    break;
                case IntegerHolder.Three:
                    enemyInfoSprite = new InfoWallmasterSprite();
                    break;
                case IntegerHolder.Four:
                    enemyInfoSprite = new InfoMoblinSprite();
                    break;
                case IntegerHolder.Five:
                    enemyInfoSprite = new InfoPeahatSprite();
                    break;
                case IntegerHolder.Six:
                    enemyInfoSprite = new InfoTektiteSprite();
                    break;
                case IntegerHolder.Seven:
                    enemyInfoSprite = new InfoKeeseSprite();
                    break;
                default:
                    break;
            }
            return enemyInfoSprite;
        }
    }
}