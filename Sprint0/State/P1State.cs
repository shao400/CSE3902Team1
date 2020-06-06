using Sprint0.Sprite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.State
{
    class P1State
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
            standing, walking, attacking, takingDmg
        }
        // salkfnlkasflkans!
        public ISprite currentSprite;
        private facing currentFacing;
        private weapon currentWeapon;
        private status currentStatus;
        public int ii =0;

        public P1State()
        {
            //initial
            currentFacing = facing.right;
            currentWeapon = weapon.None;
            currentStatus = status.standing;
            currentSprite = new LinkNoneStandingRightSprite();
        }

        public void Update()
        {
            currentSprite.Update();
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
/*            if (currentWeapon == weapon.None)
            {
                currentSprite = new LinkNoneMovingRightSprite();
            }
            else if (currentWeapon == weapon.WoodenSword)
            {
                //currentSprite = new LinkWoodenMovingRightSprite();
            }
            else if (currentWeapon == weapon.WhiteSword)
            {
                //currentSprite = new LinkWhiteMovingRightSprite();
            }
            else if (currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkMagicalSMovingUpSprite();
            }
            else if (currentWeapon == weapon.MagicalRod)
            {
                currentSprite = Sprit LinkMagicalMovingRightSprite();
            }*/
        }
        public void left()
        {
            currentStatus = status.walking;
            currentFacing = facing.left;
            currentSprite = SpriteFactory.LinkNoneMovingLeft;
            
/*            if (currentWeapon == weapon.None)
            {
                currentSprite = new LinkNoneMovingLeftSprite();
            }
            else if (currentWeapon == weapon.WoodenSword)
            {
                //currentSprite = new LinkWoodenMovingLeftSprite();
            }
            else if (currentWeapon == weapon.WhiteSword)
            {
                //currentSprite = new LinkWhiteMovingLeftSprite();
            }
            else if (currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkMagicalSMovingLeftSprite();
            }
            else if (currentWeapon == weapon.MagicalRod)
            {
                //currentSprite = new LinkMagicalRMovingLeftSprite();
            }*/
        }
        public void Up()
        {
            currentStatus = status.walking;
            currentFacing = facing.up;
            currentSprite = new LinkNoneMovingUpSprite();
            /*if (currentWeapon == weapon.None)
            {
                currentSprite = new LinkNoneMovingUpSprite();
            }
            else if (currentWeapon == weapon.WoodenSword)
            {
                //currentSprite = new LinkWoodenMovingUpSprite();
            }
            else if (currentWeapon == weapon.WhiteSword)
            {
                //currentSprite = new LinkWhiteMovingUpSprite();
            }
            else if (currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkMagicalSMovingUpSprite();
            }
            else if (currentWeapon == weapon.MagicalRod)
            {
                //currentSprite = new LinkMagicalRMovingUpSprite();
            }*/
        }
        public void Stand()
        {
            currentStatus = status.standing;
            
            if (currentFacing == facing.up)
            {
                currentSprite = new LinkNoneStandingUpSprite();
            }
            if (currentFacing == facing.down)
            {
                currentSprite = new LinkNoneStandingDownSprite();
            }
            if (currentFacing == facing.left)
            {
                currentSprite = new LinkNoneStandingLeftSprite();
            }
            if (currentFacing == facing.right)
            {
                currentSprite = new LinkNoneStandingRightSprite();
            }

        }
        public void Down()
        {
            currentStatus = status.walking;
            currentFacing = facing.down;
            currentSprite = new LinkNoneMovingDownSprite();
/*            if (currentWeapon == weapon.None)
            {
                currentSprite = new LinkNoneMovingDownSprite();
            }
            else if (currentWeapon == weapon.WoodenSword)
            {
                //currentSprite = new LinkWoodenMovingDownSprite();
            }
            else if (currentWeapon == weapon.WhiteSword)
            {
                //currentSprite = new LinkWhiteMovingDownSprite();
            }
            else if (currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkMagicalSMovingDownSprite();
            }
            else if (currentWeapon == weapon.MagicalRod)
            {
                //currentSprite = new LinkMagicalRMovingDownSprite();
            }*/
        }

        public void UseFirstItem()
        {
            currentWeapon = weapon.WoodenSword;
            if (currentFacing == facing.up)
                currentSprite = new LinkWoodenStandingUpSprite();
            else if (currentFacing == facing.down)
                currentSprite = new LinkWoodenStandingDownSprite();
            else if (currentFacing == facing.right)
                currentSprite = new LinkWoodenStandingRightSprite();
            else if (currentFacing == facing.left)
                currentSprite = new LinkWoodenStandingLeftSprite();
        }
        public void UseSecondItem()
        {
            currentWeapon = weapon.WhiteSword;
            if (currentFacing == facing.up)
                currentSprite = new LinkWhiteStandingUpSprite();
            else if (currentFacing == facing.down)
                currentSprite = new LinkWhiteStandingDownSprite();
            else if (currentFacing == facing.right)
                currentSprite = new LinkWhiteStandingRightSprite();
            else if (currentFacing == facing.left)
                currentSprite = new LinkWhiteStandingLeftSprite();
        }
/*        public void UseThirdItem()
        {
            currentWeapon = weapon.MagicalSword;
            if (currentFacing == facing.up)
                //currentSprite = new ();
            else if (currentFacing == facing.down)
                //currentSprite = new LinkMagicalSStandingDownSprite();
            else if (currentFacing == facing.right)
                //currentSprite = new LinkMagicalSStandingRightSprite();
            else if (currentFacing == facing.left)
                //currentSprite = new LinkMagicalSStandingLeftSprite();
        }*/
        public void UseFourthItem()
        {
            currentWeapon = weapon.MagicalRod;
            if (currentStatus == status.standing) {
                if (currentFacing == facing.up)
                    currentSprite = new LinkMagicalRStandingUpSprite();
                else if (currentFacing == facing.down)
                    currentSprite = new LinkMagicalRStandingDownSprite();
                else if (currentFacing == facing.right)
                    currentSprite = new LinkMagicalRStandingRightSprite();
                else if (currentFacing == facing.left)
                    currentSprite = new LinkMagicalRStandingLeftSprite();
            }
        }
        public void Attack()
        {
            currentStatus = status.attacking;
            if (currentFacing == facing.right && currentWeapon == weapon.WoodenSword)
            {
                currentSprite = new LinkWoodenAttackingRightSprite();
            }
            else if (currentFacing == facing.right && currentWeapon == weapon.WhiteSword)
            {
                currentSprite = new LinkWhiteAttackingRightSprite();
            }
            else if (currentFacing == facing.right && currentWeapon == weapon.MagicalSword)
            {
               // currentSprite = new LinkMagicalSAttackingRightSprite();
            }
            else if (currentFacing == facing.right && currentWeapon == weapon.MagicalRod)
            {
                currentSprite = new LinkMagicalRAttackingRightSprite();
            }
            else if (currentFacing == facing.left && currentWeapon == weapon.WoodenSword)
            {
                currentSprite = new LinkWoodenAttackingLeftSprite();
            }
            else if (currentFacing == facing.left && currentWeapon == weapon.WhiteSword)
            {
                currentSprite = new LinkWhiteAttackingLeftSprite();
            }
            else if (currentFacing == facing.left && currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new linkMagicalSAttackingLeftSprite();
            }
            else if (currentFacing == facing.left && currentWeapon == weapon.MagicalRod)
            {
                currentSprite = new LinkMagicalRAttackingLeftSprite();
            }
            else if (currentFacing == facing.up && currentWeapon == weapon.WoodenSword)
            {
                currentSprite = new LinkWoodenAttackingUpSprite();

            }
            else if (currentFacing == facing.up && currentWeapon == weapon.WhiteSword)
            {
                currentSprite = new LinkWhiteAttackingUpSprite();

            }
            else if (currentFacing == facing.up && currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkMagicalSAttackingUpSprite();

            }
            else if (currentFacing == facing.up && currentWeapon == weapon.MagicalRod)
            {
                currentSprite = new LinkMagicalRAttackingUpSprite();

            }
            else if (currentFacing == facing.down && currentWeapon == weapon.WoodenSword)
            {
                currentSprite = new LinkWoodenAttackingDownSprite();

            }
            else if (currentFacing == facing.down && currentWeapon == weapon.WhiteSword)
            {
                currentSprite = new LinkWhiteAttackingDownSprite();

            }
            else if (currentFacing == facing.down && currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkMagicalSAttackingDownSprite();
            }
            else if (currentFacing == facing.down && currentWeapon == weapon.MagicalRod)
            {
                currentSprite = new LinkMagicalRAttackingDownSprite();
            }
        }

        public void State_Reset()
        {
           // initialize all var that affact sprites (sprite count, location x y, Link's state)
           //item, enemy, count&location        
           // initialize blockCount
           //need to initialize location
           this.currentFacing = facing.right;
           this.currentWeapon = weapon.None;
           this.currentStatus = status.standing;
           this.currentSprite = new LinkNoneStandingRightSprite();
           
            

        }

/*        public void reloadSprite()
        {
            switch (CurrentStatus)
            {
                case status.attacking:
                    Attack();
                    break;
                case status.standing:
                    Stand();
                    break;
                case status.walking:
                    Walk();
                    break;
                case status.takingDmg:
                    TakingDmg();
                    break;
            }
        }*/
    }
}
