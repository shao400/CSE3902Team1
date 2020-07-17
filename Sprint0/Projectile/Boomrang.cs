using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;

namespace Sprint0.Projectile
{
    class Boomrang : AbstractProjectile, IProjectile
    {
        private ISprite BoomrangSprite;
        private int counter;
        private const int attackDistance = 15;
        int myDirection;
        Vector2 location;
        Vector2 moveVector;
        int totalDistance;

        private enum status
        {
            shoot, back, none
        }
        private status currentStatus;
        public Boomrang(Player1 player, int direction)
        {
            counter = 0;
            this.player = player;
            myDirection = direction;
            this.SetPosition(player.xAxis, player.yAxis);
            currentStatus = status.none;
            
        }
        public override void Update()
        {
            if (totalDistance <= 300)
            {
                currentStatus = status.shoot;
            }
            else if (totalDistance==300)
            {
                currentStatus = status.back;
            }
            
            switch (currentStatus)
            {
                case status.shoot:
                        ShotDistance += 5;
                        totalDistance = totalDistance + ShotDistance;
                    break;
                case status.back:
                    moveVector = new Vector2(player.GetRectangle().X - position.X, player.GetRectangle().Y - position.Y);
                    position.X += moveVector.X;
                    position.Y += moveVector.Y;
                    break;
                default:
                    break;
            }
            this.hitBox = new Rectangle(Convert.ToInt32(location.X), Convert.ToInt32(location.Y), 45, 23);

            // Console.WriteLine(this.rec.ToString());

        }
        public void GetPlayerLoction()
        {
            location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
        }
        public override void Shoot()
        {
            if (myDirection == 0) { 
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingUp;
                location = new Vector2(position.X, position.Y - ShotDistance);
            }
            else if (myDirection == 1) {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingDown;
                location = new Vector2(position.X, position.Y + ShotDistance);
            }
            else if (myDirection == 2) {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingRight;
                location = new Vector2(position.X + ShotDistance, position.Y);
            }
            else if (myDirection == 3) {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingLeft;
                location = new Vector2(position.X - ShotDistance, position.Y);
            }
            BoomrangSprite.Draw(location, false);
            
        }
        
        public override void Explode()
        {
            /*WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordExploding;
            //location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
            WoodenSwordSprite.Update();
            WoodenSwordSprite.Draw(location, false);*/
        }
        public override int IsExplode()
        {
            if (currentStatus == status.back)
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
                currentStatus = status.back;
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
            /*currentStatus = status.stab;
            // if (myDirection == 0) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordUp;
            //else if (myDirection == 1) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordDown;
            //else if (myDirection == 2) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordRight;
            // else if (myDirection == 3) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordLeft;
            // Vector2 location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
            if (myDirection == 0)
            {
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingUp;
                location = new Vector2(position.X, position.Y - attackDistance);
            }
            else if (myDirection == 1)
            {
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingDown;
                location = new Vector2(position.X, position.Y + attackDistance);
            }
            else if (myDirection == 2)
            {
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingRight;
                location = new Vector2(position.X + attackDistance, position.Y);
            }
            else if (myDirection == 3)
            {
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingLeft;
                location = new Vector2(position.X - attackDistance, position.Y);
            }
            WoodenSwordSprite.Draw(location, false);*/
        }

    }
}
