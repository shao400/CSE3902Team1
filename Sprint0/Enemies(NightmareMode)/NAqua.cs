using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;
using Sprint0.Collisions;
using System.Collections.Generic;
using Sprint0.Projectile;
using Sprint0.UtilityClass;
using System.Security.Cryptography;

namespace Sprint0.Enemies
{
    public class NAqua : IEnemy
    {
        private IPlayer myPlayer;        
        private ISprite AquaSprite;
        private ProjectileCollision projectileCollision;
        private IProjectile energyBall;
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
            initialX = x;
            AquaSprite = new EnemyAquaSprite(x, y);
            destinationRec = new Rectangle(x, y, IntegerHolder.OneOO, IntegerHolder.OneOO);
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
            if (counter < IntegerHolder.ThirtyFour) Born.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            if (counter == IntegerHolder.ThirtyThree) myPlayer.GetSound().bossScream1();           
            if (counter == IntegerHolder.ThirtyFive) myPlayer.GetSound().bossScream3();            
            if (this.GetHealth() > 0 && counter == IntegerHolder.ThirtyFour)
            {
                energyBall.Shoot();
                Vector2 location = new Vector2(destinationRec.X, destinationRec.Y);
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
                if (destinationRec.X - targetRec.X < 250 && targetRec.Y > destinationRec.Y && targetRec.Y < destinationRec.Y + IntegerHolder.OneOO && destinationRec.X > initialX - 250)
                {
                    destinationRec.X -= IntegerHolder.Five;
                }
                else if (targetRec.Y <= destinationRec.Y || targetRec.Y >= destinationRec.Y + IntegerHolder.OneOO)
                {
                    if (destinationRec.X < initialX) destinationRec.X += IntegerHolder.Three;
                }

                AquaSprite.Update();
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

        public void blockCollisionTest(List<IBlock> blocks)
        {

        }
    }
}