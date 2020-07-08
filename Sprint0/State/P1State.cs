using Sprint0.Items;
using Sprint0.Sprite;
using Sprint0.HUD;
using Sprint0.Projectile;
using Sprint0.Interfaces;
using Sprint0.Player;


//Author: Chuwen Sun, Zhizhou He
namespace Sprint0.State
{
    public class P1State
    {
        private enum facing
        {
            up, down, left, right
        }
        private enum weapon
        {
            None, WoodenSword, WhiteSword, MagicalSword, MagicalRod
        }
        private enum status
        {
            standing, walking, attacking, takingDmg, shooting, exploding
        }

        private Player1 player;
        public ISprite currentSprite;
        private facing currentFacing;
        private status currentStatus;
        public IProjectile currentProjectile;
        

        public P1State(Player1 player)
        {
            //initial
            this.player = player;
            currentFacing = facing.right;
            currentProjectile = new WoodenSword(player, 2);
            currentStatus = status.standing;
            currentSprite = SpriteFactory.LinkNoneStandingRight;
            
        }

        public void Update()
        {
            currentSprite.Update();
            /*if (currentProjectile != null && currentStatus == status.attacking)
            {
                currentProjectile.Update();
            }*/
        }

        public string GetCurrentWeapon()
        {

            return currentProjectile.GetType().ToString();
        }

        public string GetCurrentFacing()
        {

            return currentFacing.ToString();
        }
        public string GetCurrentStatus()
        {

            return currentStatus.ToString();
        }

        public void right()
        {
            currentStatus = status.walking;
            currentFacing = facing.right;
            currentSprite = SpriteFactory.LinkNoneMovingRight;
        }
        public void left()
        {
            currentStatus = status.walking;
            currentFacing = facing.left;
            currentSprite = SpriteFactory.LinkNoneMovingLeft;
        }
        public void Up()
        {
            currentStatus = status.walking;
            currentFacing = facing.up;
            currentSprite = SpriteFactory.LinkNoneMovingUp;
        }
        public void Stand()
        {
            currentStatus = status.standing;

            if (currentFacing == facing.up)
            {
                currentSprite = SpriteFactory.LinkNoneStandingUp;
            }
            if (currentFacing == facing.down)
            {
                currentSprite = SpriteFactory.LinkNoneStandingDown;
            }
            if (currentFacing == facing.left)
            {
                currentSprite = SpriteFactory.LinkNoneStandingLeft;
            }
            if (currentFacing == facing.right)
            {
                currentSprite = SpriteFactory.LinkNoneStandingRight;
            }
        }
        public void Down()
        {
            currentStatus = status.walking;
            currentFacing = facing.down;
            currentSprite = SpriteFactory.LinkNoneMovingDown;
        }

        public void UseFirstItem()
        {

            //if (currentFacing == facing.up)
            //;
            //else if (currentFacing == facing.down)
            //currentItem = SpriteFactory.PlayerWoodenSwordDown;
            //else if (currentFacing == facing.right)
                //currentItem = SpriteFactory.PlayerWoodenSwordRight;
            //else if (currentFacing == facing.left)
                //currentItem = SpriteFactory.PlayerWoodenSwordLeft;
            
        }
        public void UseSecondItem()
        {
            //currentWeapon = weapon.WhiteSword;
            /*if (currentStatus == status.standing)
            {
                if (currentFacing == facing.up)
                    currentSprite = SpriteFactory.LinkWhiteStandingUp;
                else if (currentFacing == facing.down)
                    currentSprite = SpriteFactory.LinkWhiteStandingDown;
                else if (currentFacing == facing.right)
                    currentSprite = SpriteFactory.LinkWhiteStandingRight;
                else if (currentFacing == facing.left)
                    currentSprite = SpriteFactory.LinkWhiteStandingLeft;
            }*/
        }
        public void UseThirdItem()
        {
            //currentWeapon = weapon.MagicalSword;
            /*if (currentStatus == status.standing)
            {
                if (currentFacing == facing.up)
                    currentSprite = SpriteFactory.LinkMagicalSStandingUp;
                else if (currentFacing == facing.down)
                    currentSprite = SpriteFactory.LinkMagicalSStandingDown;
                else if (currentFacing == facing.right)
                    currentSprite = SpriteFactory.LinkMagicalSStandingRight;
                else if (currentFacing == facing.left)
                    currentSprite = SpriteFactory.LinkMagicalSStandingLeft;
            }*/
        }
        public void UseFourthItem()
        {
            //currentWeapon = weapon.MagicalRod;
            /*if (currentStatus == status.standing)
            {
                if (currentFacing == facing.up)
                    currentSprite = SpriteFactory.LinkMagicalRStandingUp;
                else if (currentFacing == facing.down)
                    currentSprite = SpriteFactory.LinkMagicalRStandingDown;
                else if (currentFacing == facing.right)
                    currentSprite = SpriteFactory.LinkMagicalRStandingRight;
                else if (currentFacing == facing.left)
                    currentSprite = SpriteFactory.LinkMagicalRStandingLeft;
            }*/
        }
        public void Attack()
        {
            currentStatus = status.attacking;
            if (currentFacing == facing.up) currentProjectile = new WoodenSword(this.player, 0);
            else if (currentFacing == facing.down) currentProjectile = new WoodenSword(this.player, 1);
            else if (currentFacing == facing.right) currentProjectile = new WoodenSword(this.player, 2);
            else if (currentFacing == facing.left) currentProjectile = new WoodenSword(this.player, 3);
            currentProjectile.Stab();

        }
        public void Shoot() {
            currentStatus = status.shooting;
            if (currentFacing == facing.up) currentProjectile = new WoodenSword(this.player, 0);
            else if (currentFacing == facing.down) currentProjectile = new WoodenSword(this.player, 1);
            else if (currentFacing == facing.right) currentProjectile = new WoodenSword(this.player, 2);
            else if (currentFacing == facing.left) currentProjectile = new WoodenSword(this.player, 3);
            currentProjectile.Shoot();
        }
        public void Explode()
        {
            currentStatus = status.exploding;
            currentProjectile = new WoodenSword(this.player, 0);
            currentProjectile.Explode();
        }

        public void takeDmg()
        {
            currentStatus = status.takingDmg;
        }

        public bool isTakingDmg(){
            return this.currentStatus == status.takingDmg;
        }

        public void StateReset()
        {
            this.currentFacing = facing.right;
            this.currentProjectile = new WoodenSword(this.player, 2);
            this.currentStatus = status.standing;
            this.currentSprite = SpriteFactory.LinkNoneStandingRight;
        }
    }
}