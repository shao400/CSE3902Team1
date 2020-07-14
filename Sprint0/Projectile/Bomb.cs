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
            wait, explode, none
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
            if (currentStatus == status.explode && counter < 20)
            {
                counter++;
                Console.WriteLine(counter);
            }
            else if (currentStatus == status.wait)
            {
                counter = 0;
            }
            if (counter == 20)
            {
                this.GetPlayerLoction();
                currentStatus = status.none;
                counter = 21;
            }
            //if (currentStatus == status.wait) { }
            //else if (currentStatus == status.explode) { }
            this.hitBox = new Rectangle(Convert.ToInt32(location.X), Convert.ToInt32(location.Y), 45, 23);

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
            BombSprite.Update();
            BombSprite.Draw(location, false);
        }
        public override int IsExplode()
        {
            if (currentStatus == status.explode)
            {
                return 1;
            }
            else if (currentStatus == status.wait)
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
                currentStatus = status.wait;
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
