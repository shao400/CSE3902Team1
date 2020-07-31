using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System.Collections.Generic;
using Sprint0.Collisions;
using Sprint0.Projectile;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{
    public class Aqua : IEnemy 
    {
        private IPlayer myPlayer;
        private ISprite AquaSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;
        private int health = 1;
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;
        private ProjectileCollision projectileCollision1;
        private ProjectileCollision projectileCollision2;
        private ProjectileCollision projectileCollision3;
        private IProjectile energyBall;
        private IProjectile fireBallUp;
        private IProjectile fireBallDown;

        public Aqua(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            AquaSprite = new EnemyAquaSprite(x, y);
            destinationRec = new Rectangle(x, y, IntegerHolder.OneOO, IntegerHolder.OneOO);
            Born = SpriteFactory.EnemyBorn;
            Death = SpriteFactory.EnemyDeath;
            energyBall = new EnergyBall(this, myPlayer);
            fireBallUp = new FireBall(this, myPlayer, 0);
            fireBallDown = new FireBall(this, myPlayer, 1);
            projectileCollision1 = new ProjectileCollision(energyBall, myPlayer);
            projectileCollision2 = new ProjectileCollision(fireBallUp, myPlayer);
            projectileCollision3 = new ProjectileCollision(fireBallDown, myPlayer);
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
            if (counter < IntegerHolder.ThirtyFour) Born.Draw(new Vector2(destinationRec.X, yPosition), false);            
            if (this.GetHealth() > 0 && counter == IntegerHolder.ThirtyFour)
            {
                energyBall.Shoot();
                fireBallDown.Shoot();
                fireBallUp.Shoot();
                Vector2 location = new Vector2(xPosition, yPosition);
                AquaSprite.Draw(location, false);
            }
            if (counter < IntegerHolder.Seventy && this.GetHealth() == 0) Death.Draw(new Vector2(destinationRec.X, yPosition), false);            
            if (counter == IntegerHolder.ThirtyThree) myPlayer.GetSound().bossScream1();            
            if (counter == IntegerHolder.ThirtyFive) myPlayer.GetSound().bossScream3();            
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
                fireBallDown.Update();
                fireBallUp.Update();
                projectileCollision1.ProjectileLinkCollisionTest();
                projectileCollision2.ProjectileLinkCollisionTest();
                projectileCollision3.ProjectileLinkCollisionTest();
                frame++;
                if (frame >= IntegerHolder.Five) frame = 0;
                if (frame < 2 && !backmove) destinationRec.X += 1;                
                else if (frame > 2 && !backmove) destinationRec.X += 1;                
                else if (frame < 2 && backmove) destinationRec.X -= 1;                
                else if (frame > 2 && backmove) destinationRec.X -= 1;                
                if (destinationRec.X > 470) backmove = true;
                if (destinationRec.X < 440) backmove = false;
                AquaSprite.Update();
            }
        }

        public Rectangle GetRectangle()
        {
            return destinationRec;
        }

        public void xReverse(int distance, bool plus)
        {
            throw new System.NotImplementedException();
        }

        public  void yReverse(int distance, bool plus)
        {
            throw new System.NotImplementedException();
        }

        public void blockCollisionTest(List<IBlock> blocks)
        {
        }
    }
}