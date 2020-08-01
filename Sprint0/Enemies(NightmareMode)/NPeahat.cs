using System;
using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System.Collections.Generic;
using Sprint0.Collisions;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{   //Zina, Gengyi
    public class NPeahat : IEnemy
    {
        private IPlayer myPlayer;
        private ISprite PeahatSprite;
        private int xDif, yDif;
        private Rectangle destinationRec, targetRectangle;
        private EnemyAllCollision enemyAllCollision;
        private int health = IntegerHolder.Two;
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;
        public NPeahat(int x, int y, IPlayer player)
        {
            myPlayer = player;
            PeahatSprite = new NPeahatSprite();
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
                PeahatSprite.Draw(location, false);
            }
            if (counter < IntegerHolder.Seventy && this.GetHealth() == 0)
            {
                Death.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }
        }

        public  void Update()
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
                    if (xDif > 0) destinationRec.X += IntegerHolder.Two;
                    else destinationRec.X -= IntegerHolder.Two;
                }
                else
                {
                    if (yDif > 0) destinationRec.Y += IntegerHolder.Two;
                    else destinationRec.Y -= IntegerHolder.Two;
                }
                PeahatSprite.Update();
            }
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