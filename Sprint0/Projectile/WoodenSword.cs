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
    class WoodenSword : AbstractProjectile, IProjectile
    {
        private ISprite WoodenSwordSprite;
        private int counter;
        private const int attackDistance = 15;
        int myDirection;
        Vector2 location;

        private enum status
        {
            shoot, stab, explode, none
        }
        private status currentStatus;
        public WoodenSword(Player1 player, int direction)
        {
            counter = 0;
            this.player = player;
            myDirection = direction;
            this.SetPosition(player.xAxis, player.yAxis);
            currentStatus = status.none;
            this.type = "arrow";

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
            if (currentStatus == status.stab) { }
            else if (currentStatus == status.shoot) { ShotDistance+=5; }
            else if (currentStatus == status.explode) { }
            this.hitBox = new Rectangle(Convert.ToInt32(location.X), Convert.ToInt32(location.Y), 35, 23);

            // Console.WriteLine(this.rec.ToString());

        }
        public void GetPlayerLoction()
        {
            location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
        }
        public override void Shoot()
        {
            if (myDirection == 0) { 
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingUp;
                location = new Vector2(position.X, position.Y - ShotDistance);
            }
            else if (myDirection == 1) { 
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingDown;
                location = new Vector2(position.X, position.Y + ShotDistance);
            }
            else if (myDirection == 2) {
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingRight;
                location = new Vector2(position.X + ShotDistance, position.Y);
            }
            else if (myDirection == 3) { 
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingLeft;
                location = new Vector2(position.X - ShotDistance, position.Y);
            }
            WoodenSwordSprite.Draw(location, false);
            
        }
        
        public override void Explode()
        {
            WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordExploding;
            //location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
            WoodenSwordSprite.Update();
            WoodenSwordSprite.Draw(location, false);
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
            currentStatus = status.stab;
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
            WoodenSwordSprite.Draw(location, false);
        }

    }
}
