using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.Commands;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using Sprint0.UtilityClass;

namespace Sprint0.Projectile
{
    class Boomrang : AbstractProjectile, IProjectile
    {
        private ISprite BoomrangSprite;
        private int counter;
        private const int attackDistance = 15;
        int myDirection;
        Vector2 location;
        int totalDistance;
        int moveDistanceY;
        int moveDistanceX;

        private enum status
        {
            shoot, explode, none
        }
        private status currentStatus;
        public Boomrang(Player1 player, int direction)
        {
            counter = 0;
            this.player = player;
            myDirection = direction;
            this.SetPosition(player.xAxis, player.yAxis);
            currentStatus = status.none;
            this.type = StringHolder.Boomrang;

        }
        public override void Update()
        {
            if (currentStatus == status.shoot)
            { 
                ShotDistance = 5; 
            }

            else if (currentStatus == status.explode && (int)this.player.GetRectangle().X - (int)position.X <15 && (int)this.player.GetRectangle().X - (int)position.X >-15 && (int)this.player.GetRectangle().Y - (int)position.Y<15&& (int)this.player.GetRectangle().Y - (int)position.Y >-15)
            {
                this.GetPlayerLoction();
                
                currentStatus = status.none;
            }
            else if (currentStatus == status.explode)
            {                
                this.GetPlayerLoction();                
                moveDistanceX = (int)location.X - (int)position.X;
                moveDistanceY = (int)location.Y - (int)position.Y;
            }
            BoomrangSprite.Update();
            this.hitBox = new Rectangle(Convert.ToInt32(position.X), Convert.ToInt32(position.Y), 24, 24);
        }
        public void GetPlayerLoction()
        {
            location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
        }
        public override void Shoot()
        {

            if (myDirection == 0) { 
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingUp;
                position.X -=ShotDistance;
            }
            else if (myDirection == 1) {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingDown;
                position.Y += ShotDistance;
            }
            else if (myDirection == 2) {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingRight;
                position.X += ShotDistance;
            }
            else if (myDirection == 3) {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingLeft;
                position.X -= ShotDistance;
            }
            BoomrangSprite.Draw(position, false); 
        }

        public override void Explode()
        {
            if (moveDistanceX > 0)
            {
                position.X += 5;
            }
            else
            {
                position.X -= 5;
            }

            if (moveDistanceY > 0)
            {
                position.Y += 5;
            }
            else
            {
                position.Y -= 5;
            }
            /*if (myDirection == 0)
            {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingUp; 
                position = new Vector2(position.X, position.Y - moveDistanceY);
            }
            if (myDirection == 1)
            {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingDown;
                position = new Vector2(position.X, position.Y + moveDistanceY);
            }
            if (myDirection == 2)
            {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingRight;
                position = new Vector2(position.X + moveDistanceX, position.Y);
            }
            if (myDirection == 3)
            {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingLeft;
                position = new Vector2(position.X - moveDistanceX, position.Y);
            }*/ 
            BoomrangSprite.Draw(position, false);
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
