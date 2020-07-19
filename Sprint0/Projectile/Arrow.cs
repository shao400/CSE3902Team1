using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using Sprint0.UtilityClass;

namespace Sprint0.Projectile
{
    class Arrow : AbstractProjectile, IProjectile
    {
        private ISprite ArrowSprite;
        private int counter;
        int myDirection;
        Vector2 location;

        private enum status
        {
            shoot, explode, none
        }
        private status currentStatus;
        public Arrow(Player1 player, int direction)
        {
            counter = 0;
            this.player = player;
            myDirection = direction;
            this.SetPosition(player.xAxis, player.yAxis);
            currentStatus = status.none;
            this.type = StringHolder.Arrow;
            
        }
        public override void Update()
        {
            if (currentStatus == status.explode && counter < 20)
            {
                counter++;
                Console.WriteLine(counter);
            }
            else if (currentStatus == status.shoot)
            {
                counter = 0;
            }
            if (counter == 20)
            {
                this.GetPlayerLoction();
                currentStatus = status.none;
                counter = 21;
            }
            if (currentStatus == status.shoot) { ShotDistance+=5; }
            else if (currentStatus == status.explode) { }
            this.hitBox = new Rectangle(Convert.ToInt32(location.X), Convert.ToInt32(location.Y), 45, 23);
            ArrowSprite.Update();

        }
        public void GetPlayerLoction()
        {
            location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
        }
        public override void Shoot()
        {
            if (myDirection == 0) { 
                ArrowSprite = SpriteFactory.PlayerArrowShootingUp;
                location = new Vector2(position.X, position.Y - ShotDistance);
            }
            else if (myDirection == 1) { 
                ArrowSprite = SpriteFactory.PlayerArrowShootingDown;
                location = new Vector2(position.X, position.Y + ShotDistance);
            }
            else if (myDirection == 2) {
                ArrowSprite = SpriteFactory.PlayerArrowShootingRight;
                location = new Vector2(position.X + ShotDistance, position.Y);
            }
            else if (myDirection == 3) { 
                ArrowSprite = SpriteFactory.PlayerArrowShootingLeft;
                location = new Vector2(position.X - ShotDistance, position.Y);
            }
            ArrowSprite.Draw(location, false);
            
        }
        
        public override void Explode()
        {
            ArrowSprite = SpriteFactory.PlayerArrowExploding;
                        
            ArrowSprite.Draw(location, false);
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
        public override void explo(int i)
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
        public override void Stab()
        {
            throw new NotImplementedException();
        }


    }
}
