using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;
using Sprint0.Collisions;
using System.Collections.Generic;
using Sprint0.Projectile;

namespace Sprint0.Enemies
{
    public class NAqua : IEnemy
    {

        private IPlayer myPlayer;
        private ProjectileCollision projectileCollision;
        private ISprite AquaSprite;
        private IProjectile energyBall;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec, targetRec;
        private int health = 20;
        private EnemyAllCollision enemyAllCollision;
        private int initialX;
        public NAqua(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            initialX = x;
            AquaSprite = new EnemyAquaSprite(x, y);
            destinationRec = new Rectangle(xPosition, yPosition, 100, 100);
            energyBall = new EnergyBall(this, myPlayer);
            projectileCollision = new ProjectileCollision(energyBall, myPlayer);
            enemyAllCollision = new EnemyAllCollision(this);
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
            if (this.GetHealth() > 0)
            {
                energyBall.Shoot();
                Vector2 location = new Vector2(xPosition, yPosition);
                AquaSprite.Draw(location, false);
            }
        }

        public void Update()
        {
            energyBall.Update();
            projectileCollision.ProjectileLinkCollisionTest();
            targetRec = myPlayer.GetRectangle();
            if (xPosition - targetRec.X < 250 && targetRec.Y > destinationRec.Y && targetRec.Y < destinationRec.Y + 100 && xPosition > initialX - 250)
            {
                xPosition -= 5;
            }
            else if (targetRec.Y <= destinationRec.Y || targetRec.Y >= destinationRec.Y + 100)
            {
                if (xPosition < initialX) xPosition += 3;
            }

            AquaSprite.Update();
        }

        public Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, 100, 100);
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