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
        Vector2 location;

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
            location = new Vector2(position.X, position.Y);
            if (counter < 20)
            {
                counter++;
                currentStatus = status.shoot;
                Console.WriteLine(counter);
            }
            else if (counter < 50)
            {
                counter++;
                this.GetPlayerLoction();
                currentStatus = status.explode;
            }
            else if (counter >= 50)
            {
                currentStatus = status.none;
            }
            //if (currentStatus == status.wait) { }
            //else if (currentStatus == status.explode) { }
            this.hitBox = new Rectangle(Convert.ToInt32(location.X), Convert.ToInt32(location.Y), 45, 23);
            BombSprite.Update();
            // Console.WriteLine(this.rec.ToString());

        }
        public void GetPlayerLoction()
        {
            location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
        }
        public override void Shoot()
        {
            BombSprite = SpriteFactory.PlayerBomb;
            BombSprite.Draw(location, false);

        }

        public override void Explode()
        {
            BombSprite = SpriteFactory.PlayerBombExploding;
            //location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
            
            BombSprite.Draw(location, false);
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
