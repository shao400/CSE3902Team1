﻿using System;
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
        private ISprite WoodenSwordShootingSprite;
        private ISprite WoodenSwordExplodingSprite;
        private ISprite WoodenSwordSprite;
        public Rectangle rec;
        int myDirection;
        int myFrame=0;
        Vector2 location;
        Vector2 locationS;
        private enum status
        {
            shoot, stab, explode
        }
        private status currentStatus;
        public WoodenSword(Player1 player, int direction)
        {
            this.player = player;
            myDirection = direction;
            this.SetPosition(player.xAxis, player.yAxis);
            
        }
        public override void Update()
        {
            if (currentStatus == status.stab) { }
            else if (currentStatus == status.shoot) { myFrame+=5; }
            else if (currentStatus == status.explode) { }
            rec = new Rectangle(Convert.ToInt32(locationS.X), Convert.ToInt32(locationS.Y), 45, 23);
           // Console.WriteLine(this.rec.ToString());

        }
        public override void Shoot()
        {
            currentStatus = status.shoot;
            if (myDirection == 0) { 
                WoodenSwordShootingSprite = SpriteFactory.PlayerWoodenSwordShootingUp;
                locationS = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y-myFrame);
            }
            else if (myDirection == 1) { 
                WoodenSwordShootingSprite = SpriteFactory.PlayerWoodenSwordShootingDown;
                locationS = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y+myFrame);
            }
            else if (myDirection == 2) {
                WoodenSwordShootingSprite = SpriteFactory.PlayerWoodenSwordShootingRight;
                locationS = new Vector2(this.player.GetRectangle().X+myFrame, this.player.GetRectangle().Y);
            }
            else if (myDirection == 3) { 
                WoodenSwordShootingSprite = SpriteFactory.PlayerWoodenSwordShootingLeft;
                locationS = new Vector2(this.player.GetRectangle().X-myFrame, this.player.GetRectangle().Y);
            }
                WoodenSwordShootingSprite.Draw(locationS, false);
             rec = new Rectangle(Convert.ToInt32(locationS.X), Convert.ToInt32(locationS.Y), 45, 23);
            //Console.WriteLine(this.hitBox.ToString());
        }
        public override Rectangle GetHitBox()
        {
           //n Console.WriteLine(this.rec.ToString());
            return rec;
            
        }
        public override void Explode()
        {
            currentStatus = status.explode;
            WoodenSwordExplodingSprite = SpriteFactory.PlayerWoodenSwordExploding;
            location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
            WoodenSwordExplodingSprite.Update();
            WoodenSwordExplodingSprite.Draw(location, false);
        }

        public override void Stab()
        {
            currentStatus = status.stab;
            if (myDirection == 0) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordUp;
            else if (myDirection == 1) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordDown;
            else if (myDirection == 2) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordRight;
            else if (myDirection == 3) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordLeft;
            Vector2 location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
            WoodenSwordSprite.Draw(location, false);
        }


    }
}
