using System;
using Sprint0.Interfaces;
using Microsoft.Xna.Framework;
using Sprint0.Sprite;

namespace Sprint0.Projectile
{
    class EnergyBall : AbstractProjectile, IProjectile
    {
        private ISprite energyBall;
        private IEnemy enemy;
        private IPlayer mPlayer;
        private int counter;
        private int ex, ey, ShotX, ShotY, ShotDistanceX, ShotDistanceY;
        Vector2 location;

        private enum status
        {
            shoot, none, explode
        }
        private status currentStatus;
        public EnergyBall(IEnemy enemy, IPlayer player)
        {
            counter = 140;
            this.enemy = enemy;
            this.mPlayer = player;
            currentStatus = status.none;
            ShotDistance = 0;
            this.type = "energyBall";
        }
        public override void Update()
        {
            counter++;

            this.hitBox = new Rectangle(Convert.ToInt32(location.X), Convert.ToInt32(location.Y), 35, 23);

            if (counter > 150)
            {

                ShotDistanceX += ShotX;
                ShotDistanceY += ShotY;

            }
            Console.WriteLine(this.hitBox);
            if (this.hitBox.X < 0 || this.hitBox.X > 720 || this.hitBox.Y < 168 || this.hitBox.Y > 648 || this.IsExplode() == 1)
            {
                counter = 0;
                currentStatus = status.none;
                ShotDistanceX = 0;
                ShotDistanceY = 0;
                location = new Vector2(enemy.GetRectangle().X, enemy.GetRectangle().Y);
            }



        }
        public void GetPlayerLoction()
        {
            location = new Vector2(ex + ShotDistance, this.enemy.GetRectangle().Y);
        }
        public override void Shoot()
        {
            if (counter == 150)
            {
                currentStatus = status.shoot;
                ey = this.enemy.GetRectangle().Y;
                ex = this.enemy.GetRectangle().X;
                ShotX = (ex - mPlayer.GetRectangle().X) / 25;
                ShotY = (ey - mPlayer.GetRectangle().Y) / 25;
                energyBall = SpriteFactory.EnemyBlast;
            }


            if (counter >= 150 && currentStatus == status.shoot)
            {
                location = new Vector2(ex - ShotDistanceX, ey - ShotDistanceY);
                energyBall.Draw(location, false);
            }



        }

        public override void setExplo(int i)
        {
            if (i == 1)
            {
                currentStatus = status.explode;
            }
            else if (i == 0)
            {
                currentStatus = status.shoot;
            }
            else
            {
                currentStatus = status.none;
            }

        
    }

        public override int IsExplode()
        {
            if (currentStatus == status.explode)
            {
                return 1;
            }
            else if (currentStatus == status.shoot)
            {
                return 0;
            }
            
            else
            {
                return 2;
            }
        }

        public override void Explode()
        {
            throw new NotImplementedException();
        }

        public override void Stab()
        {
            throw new NotImplementedException();
        }

        public override int getCounter()
        {
            throw new NotImplementedException();
        }
    }
}
