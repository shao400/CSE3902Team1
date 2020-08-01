using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using Sprint0.Collisions;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{
    public class NMoblin : IEnemy
    {


        private IPlayer myPlayer;
        private ISprite MoblinSprite;
        private int  xDif, yDif;
        bool leftmove = false;
        private Rectangle destinationRec, targetRectangle;
        private EnemyAllCollision enemyAllCollision;
        private List<IBlock> blocksSet;
        private int counter = 0;
        private Boolean chaseLink = false;
        private int health = IntegerHolder.Three; 
        private ISprite Born;
        private ISprite Death;
        private int counter2 = 0;
        public NMoblin(int x, int y, IPlayer player, List<IBlock> blocks)
        {
            myPlayer = player;
            MoblinSprite = new NMoblinSprite();
            destinationRec = new Rectangle(x, y, IntegerHolder.ThirtyFive, IntegerHolder.ThirtyFive);
            enemyAllCollision = new EnemyAllCollision(this);
            blocksSet = blocks;
            Born = SpriteFactory.EnemyBorn;
            Death = SpriteFactory.EnemyDeath;
        }

        public void Damaged()
        {
            health--;

        }
        public int GetHealth()
        {
            return health;
        }

        public void Draw()
        {
            if (counter2 < IntegerHolder.ThirtyFour)
            {
                Born.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }

            if (this.GetHealth() > 0 && counter2 == IntegerHolder.ThirtyFour)
            {
                Vector2 location = new Vector2(destinationRec.X, destinationRec.Y);
                MoblinSprite.Draw(location, leftmove);
            }
            if (counter2 < IntegerHolder.Seventy && this.GetHealth() == 0)
            {
                Death.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }
        }

        public void Update()
        {
            if (counter2 < IntegerHolder.ThirtyFour)
            {
                Born.Update();
                counter2++;
            }
            else if (counter2 >= IntegerHolder.ThirtyFour && this.GetHealth() == 0 && counter2 < IntegerHolder.Seventy)
            {
                Death.Update();
                counter2++;
            }
            else
            {
                targetRectangle = myPlayer.GetRectangle();
                xDif = targetRectangle.X - destinationRec.X;
                yDif = targetRectangle.Y - destinationRec.Y;

                if (seeLink() && !chaseLink) counter++;
                if (!seeLink() && chaseLink) counter--;
                if (counter > 18) { counter = 18; chaseLink = true; }
                else if (counter < 0) { counter = 0; chaseLink = false; }
                if (chaseLink)
                {
                    if (Math.Abs(xDif) > Math.Abs(yDif))
                    {
                        if (xDif > 0) { destinationRec.X += IntegerHolder.One; leftmove = false; }
                        else { destinationRec.X -= IntegerHolder.One; leftmove = true; }
                    }
                    else
                    {
                        if (yDif > 0) destinationRec.Y += IntegerHolder.One;
                        else destinationRec.Y -= IntegerHolder.One;
                    }
                }
                MoblinSprite.Update();
            }
        }

        private Boolean seeLink()
        {
            Boolean detected = true;
            int dx = xDif/2;
            int dy = yDif /2;

                if (destinationRec.X > targetRectangle.X && destinationRec.Y > targetRectangle.Y)
                { 
                if (enemyAllCollision.BlockCollisionDetect(blocksSet, destinationRec.X - dx, destinationRec.Y - dy, 1)) detected = false;
                else detected = true;
                }
                if (destinationRec.X <= targetRectangle.X && destinationRec.Y > targetRectangle.Y)
                {
                if (enemyAllCollision.BlockCollisionDetect(blocksSet, destinationRec.X + dx, destinationRec.Y - dy, 1)) detected = false;
                else detected = true;
                }
                 if (destinationRec.X <= targetRectangle.X && destinationRec.Y <= targetRectangle.Y)
                { 
                if(enemyAllCollision.BlockCollisionDetect(blocksSet, destinationRec.X +  dx, destinationRec.Y +  dy, 1)) detected = false; 
                else detected = true; 
                }
                 if (destinationRec.X > targetRectangle.X && destinationRec.Y <= targetRectangle.Y)
                {
                if( enemyAllCollision.BlockCollisionDetect(blocksSet, destinationRec.X - dx, destinationRec.Y +  dy, 1)) detected = false; 
                else detected = true; 
                }

            return detected;
        }

     

        public Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(destinationRec.X, destinationRec.Y, IntegerHolder.ThirtyFive, IntegerHolder.ThirtyFive);
            return destinationRec;
        }

        public void xReverse(int distance, bool plus)
        {
            if (plus) destinationRec.X += distance;
            else { destinationRec.X -= distance; }
        }

        public void yReverse(int distance, bool plus)
        {
            if (plus) destinationRec.Y += distance;
            else { destinationRec.Y -= distance; }
        }

        public void blockCollisionTest(List<IBlock> blocks) { }
    }
}