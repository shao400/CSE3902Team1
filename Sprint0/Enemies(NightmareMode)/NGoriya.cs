using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;
using Sprint0.Collisions;
using Sprint0.Projectile;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Sprint0.Enemies
{
    public class NGoriya : AbstractEnemies, IEnemy
    {
        private IPlayer myPlayer;
        private ProjectileCollision projectileCollision;
        private ISprite GoriyaSprite;
        private int xPosition, yPosition, xDif, yDif;
        bool leftmove = false;
        private Rectangle destinationRec, targetRectangle;
        private EnemyAllCollision enemyAllCollision;
        private IProjectile energyBall;
        private int health = 4;

        public NGoriya(int x, int y, IPlayer player)
        {
           
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            GoriyaSprite = new NGoriyaSprite();
            destinationRec = new Rectangle(x, y, 45, 45);
            enemyAllCollision = new EnemyAllCollision(this);
            energyBall = new EnergyBall(this, myPlayer);
            projectileCollision = new ProjectileCollision(energyBall, myPlayer);
        }

        public void Damaged()
        {
            health--;

        }
        public int GetHealth()
        {
            return health;
        }

        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                energyBall.Shoot();
                Vector2 location = new Vector2(xPosition, yPosition);
                GoriyaSprite.Draw(location, leftmove);
            }
            
        }

        public override void Update()
        {
            energyBall.Update();
            projectileCollision.ProjectileLinkCollisionTest();
            targetRectangle = myPlayer.GetRectangle();
            xDif = targetRectangle.X - xPosition;
            yDif = targetRectangle.Y - yPosition;
            if (Math.Abs(xDif) > Math.Abs(yDif))
            {
                if (xDif > 0) { xPosition += 1; leftmove = false; }
                else { xPosition -= 1; leftmove = true; }
            }
            else
            {
                if (yDif > 0) yPosition += 1;
                else yPosition -= 1;
            }           
            GoriyaSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, 45, 45);
            return destinationRec;                                  
        }

        public override void xReverse(int distance, bool plus)
        {
            if (plus) xPosition += distance;
            else { xPosition -= distance; }
        }

        public override void yReverse(int distance, bool plus)
        {
            if (plus) yPosition += distance;
            else { yPosition -= distance; }
        }

        public override void blockCollisionTest(List<IBlock> blocks) { enemyAllCollision.BlockCollisionTest(blocks); }
    }
}