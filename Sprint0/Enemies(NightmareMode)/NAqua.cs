using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;
using Sprint0.Collisions;
using System.Collections.Generic;
using Sprint0.Projectile;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{
    public class NAqua : IEnemy
    {

        private IPlayer myPlayer;
        
        private ISprite AquaSprite;
        private ProjectileCollision projectileCollision;
        private IProjectile energyBall;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec, targetRec;
        private int health = 20;
        private EnemyAllCollision enemyAllCollision;
        private int initialX;
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;
        public NAqua(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            initialX = x;
            AquaSprite = new EnemyAquaSprite(x, y);
            destinationRec = new Rectangle(xPosition, yPosition, IntegerHolder.OneOO, IntegerHolder.OneOO);
            energyBall = new EnergyBall(this, myPlayer);
            projectileCollision = new ProjectileCollision(energyBall, myPlayer);
            enemyAllCollision = new EnemyAllCollision(this);
            Born = SpriteFactory.EnemyBorn;
            Death = SpriteFactory.EnemyDeath;
        }


        public void Damaged()
        {
            health--;
            myPlayer.GetSound().bossScream2();

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
            if (counter == IntegerHolder.ThirtyThree)
            {
                myPlayer.GetSound().bossScream1();
            }
            if (counter == IntegerHolder.ThirtyFive)
            {
                myPlayer.GetSound().bossScream3();
            }
            if (this.GetHealth() > 0 && counter == IntegerHolder.ThirtyFour)
            {
                energyBall.Shoot();
                Vector2 location = new Vector2(xPosition, yPosition);
                AquaSprite.Draw(location, false);
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
                energyBall.Update();
                projectileCollision.ProjectileLinkCollisionTest();
                targetRec = myPlayer.GetRectangle();
                if (xPosition - targetRec.X < 250 && targetRec.Y > destinationRec.Y && targetRec.Y < destinationRec.Y + IntegerHolder.OneOO && xPosition > initialX - 250)
                {
                    xPosition -= IntegerHolder.Five;
                }
                else if (targetRec.Y <= destinationRec.Y || targetRec.Y >= destinationRec.Y + IntegerHolder.OneOO)
                {
                    if (xPosition < initialX) xPosition += IntegerHolder.Three;
                }

                AquaSprite.Update();
            }
        }

        public Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, IntegerHolder.OneOO, IntegerHolder.OneOO);
            return destinationRec;
        }

        public void xReverse(int distance, bool plus)
        {
            if (plus) xPosition += distance;
            else { xPosition -= distance; }
        }

        public void yReverse(int distance, bool plus)
        {
            if (plus) yPosition += distance;
            else { yPosition -= distance; }
        }

        public void blockCollisionTest(List<IBlock> blocks)
        {
            //enemyAllCollision.BlockCollisionTest(blocks);
        }
    }
}