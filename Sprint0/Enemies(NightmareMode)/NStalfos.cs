using System;
using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Collisions;
using System.Collections.Generic;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{
    public class NStalfos : IEnemy
    {

        private IPlayer myPlayer;
        private ISprite StalfosSprite;
        private int  xDif, yDif;
        private Rectangle destinationRec, targetRectangle;
        private bool leftmove = false;
        private EnemyAllCollision enemyAllCollision;
        private int health = IntegerHolder.One;
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;
        public NStalfos(int x, int y, IPlayer link)
        {
            myPlayer = link;
            StalfosSprite = new NStalfosSprite();
            destinationRec = new Rectangle(x, y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive);
            enemyAllCollision = new EnemyAllCollision(this);
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
            if (counter < IntegerHolder.ThirtyFour)
            {
                Born.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }

            if (this.GetHealth() > 0 && counter == IntegerHolder.ThirtyFour)
            {
                Vector2 location = new Vector2(destinationRec.X, destinationRec.Y);
                StalfosSprite.Draw(location, leftmove);
            }
            if (counter < IntegerHolder.Seventy && this.GetHealth() == 0)
            {
                Death.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }
        }

        public void Update()
        {
            if (counter < IntegerHolder.ThirtyFour)
            {
                Born.Update();
                counter++;
            }
            else if (counter >= IntegerHolder.ThirtyFour && this.GetHealth() == 0 && counter < IntegerHolder.Seventy)
            {
                Death.Update();
                counter++;
            }
            else
            {
                targetRectangle = myPlayer.GetRectangle();
                xDif = targetRectangle.X - destinationRec.X;
                yDif = targetRectangle.Y - destinationRec.Y;
                if (Math.Abs(xDif) > Math.Abs(yDif))
                {
                    if (xDif > 0) { destinationRec.X += 1; leftmove = false; }
                    else { destinationRec.X -= 1; leftmove = true; }
                }
                else
                {
                    if (yDif > 0) destinationRec.Y += 1;
                    else destinationRec.Y -= 1;
                }
                if (Math.Abs(xDif) > 300 || Math.Abs(yDif) > 300) Flash();
                StalfosSprite.Update();
            }
        }

        private void Flash()
        {
            //A counter maybe needed
            targetRectangle = myPlayer.GetRectangle();
            destinationRec.X = targetRectangle.X;
            destinationRec.Y = targetRectangle.Y;
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
        public void blockCollisionTest(List<IBlock> blocks) { enemyAllCollision.BlockCollisionTest(blocks); }

    }
}