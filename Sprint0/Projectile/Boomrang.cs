using System;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using Sprint0.UtilityClass;

namespace Sprint0.Projectile
{
    class Boomrang : AbstractProjectile, IProjectile
    {
        private ISprite BoomrangSprite;
        int myDirection;
        Vector2 location;
        int moveDistanceY;
        int moveDistanceX;

        private enum status
        {
            shoot, explode, none
        }
        private status currentStatus;
        public Boomrang(Player1 player, int direction)
        {
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
                ShotDistance = IntegerHolder.Five; 
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
            if (this.hitBox.X < 0 || this.hitBox.X > 720 || this.hitBox.Y < IntegerHolder.OneSixEight || this.hitBox.Y > 648)
            {
                currentStatus = status.none;
            }
        }
        public void GetPlayerLoction()
        {
            location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
        }
        public override void Shoot()
        {

            if (myDirection == 0) { 
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingUp;
                position.Y -=ShotDistance;
            }
            else if (myDirection == 1) {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingDown;
                position.Y += ShotDistance;
            }
            else if (myDirection == 2) {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingRight;
                position.X += ShotDistance;
            }
            else if (myDirection == IntegerHolder.Three) {
                BoomrangSprite = SpriteFactory.PlayerBoomrangShootingLeft;
                position.X -= ShotDistance;
            }
            BoomrangSprite.Draw(position, false); 
        }

        public override void Explode()
        {
            if (moveDistanceX > 0)
            {
                position.X += IntegerHolder.Five;
            }
            else
            {
                position.X -= IntegerHolder.Five;
            }

            if (moveDistanceY > 0)
            {
                position.Y += IntegerHolder.Five;
            }
            else
            {
                position.Y -= IntegerHolder.Five;
            }
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
        public override void setExplo(int i)
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

        public override int getCounter()
        {
            throw new NotImplementedException();
        }
    }
}
