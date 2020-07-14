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
    public class Bomb : AbstractProjectile, IProjectile
    {
        private ISprite BombSprite;
        private int counter;

        private enum status
        {
            shoot, explode, none
        }
        private status currentStatus;
        public Bomb(Player1 player, int direction)
        {
            counter = 0;
            this.player = player;
            this.SetPosition(player.xAxis, player.yAxis);
            currentStatus = status.none;

        }
        public override void Update()
        {            
            if (counter < 20)
            {
                counter++;
                currentStatus = status.shoot;
            }
            else if (counter < 50)
            {
                counter++;
                currentStatus = status.explode;
            }
            else if (counter >= 50)
            {
                currentStatus = status.none;
            }
            //if (currentStatus == status.wait) { }
            //else if (currentStatus == status.explode) { }
            this.hitBox = new Rectangle(Convert.ToInt32(position.X), Convert.ToInt32(position.Y), 45, 23);
            if (counter >= 20 && counter < 50)
            {
                BombSprite.Update();
            }
            // Console.WriteLine(this.rec.ToString());

        }
        
        public override void Shoot()
        {
            BombSprite = SpriteFactory.PlayerBomb;
            BombSprite.Draw(position, false);

        }

        public override void Explode()
        {
            BombSprite = SpriteFactory.PlayerBombExploding;        
            BombSprite.Draw(position, false);
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
