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

        private ISprite currentSprite;
        private facing currentFacing;
        private weapon currentWeapon;
        private status currentStatus;

        public P1State()// 可能不需要parameter因为P1里面有P1State，P1State里面也不需要P1
        {
            //initial
            currentFacing = facing.right;
            currentWeapon = weapon.None;
            currentStatus = status.standing;
            currentSprite = new LinkNoneStandingRightSprite();
        }

        public void Update()
        {
            //FACING UP
            if (this.currentFacing == facing.up)
            {
                //FACING UP -> STANDING
                if (this.currentStatus == status.standing)
                {
                    //FACING UP -> STANDING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {

                    }
                    //FACING UP -> STANDING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING UP -> STANDING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING UP -> STANDING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING UP -> STANDING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING UP -> ATTACKING
                if (this.currentStatus == status.attacking)
                {
                    //FACING UP -> ATTACKING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {
                        //啥都不干
                    }
                    //FACING UP -> ATTACKING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING UP -> ATTACKING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING UP -> ATTACKING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING UP -> ATTACKING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING UP -> WALKING
                if (this.currentStatus == status.walking)
                {
                    //FACING UP -> WALKING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {
                        
                    }
                    //FACING UP -> WALKING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING UP -> WALKING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING UP -> WALKING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING UP -> WALKING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING UP -> TAKINGDMG
                if (this.currentStatus == status.takingDmg)
                {
                    //FACING UP -> TAKINGDMG -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {

                    }
                    //FACING UP -> TAKINGDMG -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING UP -> TAKINGDMG -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING UP -> TAKINGDMG -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING UP -> TAKINGDMG -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
            }
            //FACING DOWN
            if (this.currentFacing == facing.down)
            {
                //FACING DOWN -> STANDING
                if (this.currentStatus == status.standing)
                {
                    //FACING DOWN -> STANDING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {

                    }
                    //FACING DOWN -> STANDING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING DOWN -> STANDING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING DOWN -> STANDING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING DOWN -> STANDING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING DOWN -> ATTACKING
                if (this.currentStatus == status.attacking)
                {
                    //FACING DOWN -> ATTACKING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {
                        //啥都不干
                    }
                    //FACING DOWN -> ATTACKING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING DOWN -> ATTACKING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING DOWN -> ATTACKING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING DOWN -> ATTACKING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING DOWN -> WALKING
                if (this.currentStatus == status.walking)
                {
                    //FACING DOWN -> WALKING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {

                    }
                    //FACING DOWN -> WALKING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING DOWN -> WALKING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING DOWN -> WALKING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING DOWN -> WALKING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING DOWN -> TAKINGDMG
                if (this.currentStatus == status.takingDmg)
                {
                    //FACING DOWN -> TAKINGDMG -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {

                    }
                    //FACING DOWN -> TAKINGDMG -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING DOWN -> TAKINGDMG -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING DOWN -> TAKINGDMG -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING DOWN -> TAKINGDMG -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
            }
            //FACING LEFT
            if (this.currentFacing == facing.left)
            {
                //FACING LEFT -> STANDING
                if (this.currentStatus == status.standing)
                {
                    //FACING LEFT -> STANDING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {

                    }
                    //FACING LEFT -> STANDING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING LEFT -> STANDING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING LEFT -> STANDING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING LEFT -> STANDING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING LEFT -> ATTACKING
                if (this.currentStatus == status.attacking)
                {
                    //FACING LEFT -> ATTACKING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {
                        //啥都不干
                    }
                    //FACING LEFT -> ATTACKING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING LEFT -> ATTACKING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING LEFT -> ATTACKING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING LEFT -> ATTACKING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING LEFT -> WALKING
                if (this.currentStatus == status.walking)
                {
                    //FACING LEFT -> WALKING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {

                    }
                    //FACING LEFT -> WALKING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING LEFT -> WALKING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING LEFT -> WALKING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING LEFT -> WALKING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING LEFT -> TAKINGDMG
                if (this.currentStatus == status.takingDmg)
                {
                    //FACING LEFT -> TAKINGDMG -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {

                    }
                    //FACING LEFT -> TAKINGDMG -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING LEFT -> TAKINGDMG -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING LEFT -> TAKINGDMG -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING LEFT -> TAKINGDMG -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
            }
            //FACING RIGHT
            if (this.currentFacing == facing.right)
            {
                //FACING RIGHT -> STANDING
                if (this.currentStatus == status.standing)
                {
                    //FACING RIGHT -> STANDING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {

                    }
                    //FACING RIGHT -> STANDING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING RIGHT -> STANDING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING RIGHT -> STANDING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING RIGHT -> STANDING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING RIGHT -> ATTACKING
                if (this.currentStatus == status.attacking)
                {
                    //FACING RIGHT -> ATTACKING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {
                        //啥都不干
                    }
                    //FACING RIGHT -> ATTACKING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING RIGHT -> ATTACKING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING RIGHT -> ATTACKING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING RIGHT -> ATTACKING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING RIGHT -> WALKING
                if (this.currentStatus == status.walking)
                {
                    //FACING RIGHT -> WALKING -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {

                    }
                    //FACING RIGHT -> WALKING -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING RIGHT -> WALKING -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING RIGHT -> WALKING -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING RIGHT -> WALKING -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
                //FACING RIGHT -> TAKINGDMG
                if (this.currentStatus == status.takingDmg)
                {
                    //FACING RIGHT -> TAKINGDMG -> NO_WEAPON
                    if (this.currentWeapon == weapon.None)
                    {

                    }
                    //FACING RIGHT -> TAKINGDMG -> WOODENSWORD
                    if (this.currentWeapon == weapon.WoodenSword)
                    {

                    }
                    //FACING RIGHT -> TAKINGDMG -> WHITESWORD
                    if (this.currentWeapon == weapon.WhiteSword)
                    {

                    }
                    //FACING RIGHT -> TAKINGDMG -> MAGICALSWORD
                    if (this.currentWeapon == weapon.MagicalSword)
                    {

                    }
                    //FACING RIGHT -> TAKINGDMG -> MAGICALROD
                    if (this.currentWeapon == weapon.MagicalRod)
                    {

                    }
                }
            }
        }

        public void right()
        {
            currentStatus = status.walking;
            currentFacing = facing.right;
            if (currentWeapon == weapon.None)
            {
                currentSprite = new LinkNoneMovingRightSprite();
            }
            else if (currentWeapon == weapon.WoodenSword)
            {
                currentSprite = new LinkWoodenMovingRightSprite();
            }
            else if (currentWeapon == weapon.WhiteSword)
            {
                currentSprite = new LinkWhiteMovingRightSprite();
            }
            else if (currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkMagicalSMovingUpSprite();
            }
            else if (currentWeapon == weapon.MagicalRod)
            {
                //currentSprite = new LinkMagicalMovingRightSprite();
            }
        }

        public void left()
        {
            currentStatus = status.walking;
            currentFacing = facing.left;
            if (currentWeapon == weapon.None)
            {
                currentSprite = new LinkNoneMovingLeftSprite();
            }
            else if (currentWeapon == weapon.WoodenSword)
            {
                currentSprite = new LinkWoodenMovingLeftSprite();
            }
            else if (currentWeapon == weapon.WhiteSword)
            {
                currentSprite = new LinkWhiteMovingLeftSprite();
            }
            else if (currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkMagicalSMovingLeftSprite();
            }
            else if (currentWeapon == weapon.MagicalRod)
            {
                currentSprite = new LinkMagicalRMovingLeftSprite();
            }
        }

        public void Up()
        {
            currentStatus = status.walking;
            currentFacing = facing.up;
            if (currentWeapon == weapon.None)
            {
                currentSprite = new LinkNoneMovingUpSprite();
            }
            else if (currentWeapon == weapon.WoodenSword)
            {
                currentSprite = new LinkWoodenMovingUpSprite();
            }
            else if (currentWeapon == weapon.WhiteSword)
            {
                currentSprite = new LinkWhiteMovingUpSprite();
            }
            else if (currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkMagicalSMovingUpSprite();
            }
            else if (currentWeapon == weapon.MagicalRod)
            {
                currentSprite = new LinkMagicalRMovingUpSprite();
            }
        }

        public void Down()
        {
            currentStatus = status.walking;
            currentFacing = facing.down;
            if (currentWeapon == weapon.None)
            {
                currentSprite = new LinkNoneMovingDownSprite();
            }
            else if (currentWeapon == weapon.WoodenSword)
            {
                currentSprite = new LinkWoodenMovingDownSprite();
            }
            else if (currentWeapon == weapon.WhiteSword)
            {
                currentSprite = new LinkWhiteMovingDownSprite();
            }
            else if (currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkMagicalSMovingDownSprite();
            }
            else if (currentWeapon == weapon.MagicalRod)
            {
                currentSprite = new LinkMagicalRMovingDownSprite();
            }
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

       /* public void UseThirdItem()
        {
            currentWeapon = weapon.MagicalSword;
            if (currentFacing == facing.up)
                //currentSprite = new LinkMagicalSStandingUpSprite();
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
            if (currentFacing == facing.up)
                currentSprite = new LinkMagicalRStandingUpSprite();
            else if (currentFacing == facing.down)
                currentSprite = new LinkMagicalRStandingDownSprite();
            else if (currentFacing == facing.right)
                currentSprite = new LinkMagicalRStandingRightSprite();
            else if (currentFacing == facing.left)
                currentSprite = new LinkMagicalRStandingLeftSprite();
        }

        public void Attack()
        {
            currentStatus = status.attacking;
            if (currentFacing == facing.right && currentWeapon == weapon.WoodenSword)
            {
                //currentSprite = new LinkWoodenStandRightAttack();
            }
            else if (currentFacing == facing.right && currentWeapon == weapon.WhiteSword)
            {
                //currentSprite = new LinkWhiteStandRightAttack();
            }
            else if (currentFacing == facing.right && currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkNoneStandRightAttack();
            }
            else if (currentFacing == facing.right && currentWeapon == weapon.MagicalRod)
            {
                //currentSprite = new LinkNoneStandRightAttack();
            }
            else if (currentFacing == facing.left && currentWeapon == weapon.WoodenSword)
            {
                //currentSprite = new LinkNoneStandRightAttack();
            }
            else if (currentFacing == facing.left && currentWeapon == weapon.WhiteSword)
            {
                //currentSprite = new LinkNoneStandRightAttack();
            }
            else if (currentFacing == facing.left && currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkNoneStandRightAttack();
            }
            else if (currentFacing == facing.left && currentWeapon == weapon.MagicalRod)
            {
                //currentSprite = new LinkNoneStandRightAttack();

            }
            else if (currentFacing == facing.up && currentWeapon == weapon.WoodenSword)
            {
                //currentSprite = new LinkNoneStandRightAttack();

            }
            else if (currentFacing == facing.up && currentWeapon == weapon.WhiteSword)
            {
                //currentSprite = new LinkNoneStandRightAttack();

            }
            else if (currentFacing == facing.up && currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkNoneStandRightAttack();

            }
            else if (currentFacing == facing.up && currentWeapon == weapon.MagicalRod)
            {
                //currentSprite = new LinkNoneStandRightAttack();

            }
            else if (currentFacing == facing.down && currentWeapon == weapon.WoodenSword)
            {
                //currentSprite = new LinkNoneStandRightAttack();

            }
            else if (currentFacing == facing.down && currentWeapon == weapon.WhiteSword)
            {
                //currentSprite = new LinkNoneStandRightAttack();

            }
            else if (currentFacing == facing.down && currentWeapon == weapon.MagicalSword)
            {
                //currentSprite = new LinkNoneStandRightAttack();

            }
            else if (currentFacing == facing.down && currentWeapon == weapon.MagicalRod)
            {
               // currentSprite = new LinkNoneStandRightAttack();
            }
        }
        public void Reset()
        {
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
