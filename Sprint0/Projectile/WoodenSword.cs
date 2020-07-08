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

        public WoodenSword(Player1 player, int direction)
        {
            this.player = player;
            if (direction == 0) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordUp;
            else if (direction == 1) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordDown;
            else if (direction == 2) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordRight;
            else if (direction == 3) WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordLeft;
            this.SetPosition(player.xAxis, player.yAxis);
        }

        public override void Shoot()
        {
            throw new NotImplementedException();
        }

        public override void Explode()
        {
            throw new NotImplementedException();
        }

        public override void Stab()
        {
            Vector2 location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
            WoodenSwordSprite.Draw(location, false);
        }

        public override void Update()
        {
            
        }
    }
}
