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
    public class Boom : AbstractProjectile, IProjectile
    {
        private ISprite BoomSprite;
        private int counter;
        int myDirection;
        Vector2 location;

        public Boom(Player1 player, int direction)
        {
            counter = 0;
            this.player = player;
            myDirection = direction;
            this.SetPosition(player.xAxis, player.yAxis);
            
        }
        public override void Update()
        {
            if (counter < 20) { counter++; }
            
            if (counter == 20)
            {
                this.GetPlayerLoction();
                counter = 0;
            }
            this.hitBox = new Rectangle(Convert.ToInt32(location.X), Convert.ToInt32(location.Y), 45, 23);

            // Console.WriteLine(this.rec.ToString());

        }
        public void GetPlayerLoction()
        {
            location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
        }

        public override void Explode()
        {
            BoomSprite = SpriteFactory.PlayerBoomSprite;
            //location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
            BoomSprite.Update();
            BoomSprite.Draw(location, false);
        }
        public override void explo(int i) { }
        public override int IsExplode() { return 0; }
        public override void Shoot() { }
        public override void Stab() { }

    }
}
