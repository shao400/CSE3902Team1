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
            destinationRec = new Rectangle(xPosition, yPosition, 100, 100);
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
            if (counter < 34)
            {
                Born.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
                
            }
            if (counter == 33)
            {
                myPlayer.GetSound().bossScream1();
            }
            if (counter == 35)
            {
                myPlayer.GetSound().bossScream3();
            }
            if (this.GetHealth() > 0 && counter == 34)
            {
                energyBall.Shoot();
                Vector2 location = new Vector2(xPosition, yPosition);
                AquaSprite.Draw(location, false);
            }
            if (counter < 70 && this.GetHealth() == 0)
            {
                Death.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }
        }

        public void Update()
        {
            if (counter < 34)
            {
                Born.Update();
                counter++;
            }
            else if (counter >= 34 && this.GetHealth() == 0 && counter < 70)
            {
                Death.Update();
                counter++;
            }
            else
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