using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sprint0.Enemies;
using Sprint0.Interfaces;
using Microsoft.Xna.Framework;
using Sprint0.Projectile;
using Sprint0.Sprite;

namespace Sprint0.Projectile_Enemy_
{
    class EnergyBall : AbstractProjectile, IProjectile
    {
        private ISprite energyBall;
        private IEnemy enemy;
        private int counter;
        private int y;
        private const int attackDistance = 15;
        int myDirection;
        Vector2 location, location2;

        private enum status
        {
            shoot, none
        }
        private status currentStatus;
        public EnergyBall(IEnemy enemy)
        {
            counter = 0;
            this.enemy = enemy;
            currentStatus = status.none;
            this.type = "arrow";
            y = this.enemy.GetRectangle().Y;

        }
        public override void Update()
        {
            counter++;
            if (counter == 10)
            {
                y = this.enemy.GetRectangle().Y;
                ShotDistance += 5;

            }
            if (this.hitBox.X < 0 || this.hitBox.X > 720 || this.hitBox.Y < 168 || this.hitBox.Y > 648)
            {
                counter = 0;

            }



        }
        public void GetPlayerLoction()
        {
            location = new Vector2(this.enemy.GetRectangle().X, this.enemy.GetRectangle().Y);
        }
        public override void Shoot()
        {
          
                energyBall = SpriteFactory.EnemyBlast;
                location = new Vector2(this.enemy.GetRectangle().X, y + ShotDistance);

            energyBall.Draw(location, false);

        }

        public override void setExplo(int i)
        {
            throw new NotImplementedException();
        }

        public override int IsExplode()
        {
            throw new NotImplementedException();
        }

        public override void Explode()
        {
            throw new NotImplementedException();
        }

        public override void Stab()
        {
            throw new NotImplementedException();
        }
    }
}
