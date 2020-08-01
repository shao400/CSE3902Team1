using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;
using Sprint0.Collisions;
using Sprint0.Projectile;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{
    public class NGoriya :  IEnemy
    {
        private IPlayer myPlayer;
        private ProjectileCollision projectileCollision;
        private ISprite GoriyaSprite;
        private int xDif, yDif;
        bool leftmove = false;
        private Rectangle destinationRec, targetRectangle;
        private EnemyAllCollision enemyAllCollision;
        private IProjectile energyBall;
        private int health = IntegerHolder.Four;
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;

        public NGoriya(int x, int y, IPlayer player)
        {       
            myPlayer = player;
            GoriyaSprite = new NGoriyaSprite();
            destinationRec = new Rectangle(x, y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive);
            enemyAllCollision = new EnemyAllCollision(this);
            energyBall = new EnergyBall(this, myPlayer);
            projectileCollision = new ProjectileCollision(energyBall, myPlayer);
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
                energyBall.Shoot();
                Vector2 location = new Vector2(destinationRec.X, destinationRec.Y);
                GoriyaSprite.Draw(location, leftmove);
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
                targetRectangle = myPlayer.GetRectangle();
                xDif = targetRectangle.X - destinationRec.X;
                yDif = targetRectangle.Y - destinationRec.Y;
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
                GoriyaSprite.Update();
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