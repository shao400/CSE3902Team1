using Sprint0.Items;
using Sprint0.Sprite;
using Sprint0.HUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;


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
            standing, walking, attacking, takingDmg
        }

        public ISprite currentSprite;
        private facing currentFacing;
        private weapon currentWeapon;
        private status currentStatus;
        public ISprite currentItem;
        

        public P1State()
        {
            //initial
            currentFacing = facing.right;
            currentWeapon = weapon.None;
            currentStatus = status.standing;
            currentSprite = SpriteFactory.LinkNoneStandingRight;
            
        }

        public void Update()
        {
            currentSprite.Update();
            if (currentItem != null && currentStatus == status.attacking)
            {
                currentItem.Update();
            }
        }

        public string GetCurrentWeapon()
        {

            return currentWeapon.ToString();
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
            currentWeapon = weapon.WoodenSword;
            
            
            //if (currentStatus == status.standing)
            //{
                if (currentFacing == facing.up)
                    currentItem = SpriteFactory.PlayerWoodenSwordUp;
                else if (currentFacing == facing.down)
                    currentItem = SpriteFactory.PlayerWoodenSwordDown;
                else if (currentFacing == facing.right)
                    currentItem = SpriteFactory.PlayerWoodenSwordRight;
                else if (currentFacing == facing.left)
                    currentItem = SpriteFactory.PlayerWoodenSwordLeft;
            //}
        }
        public void UseSecondItem()
        {
            currentWeapon = weapon.WhiteSword;
            if (currentStatus == status.standing)
            {
                if (currentFacing == facing.up)
                    currentSprite = SpriteFactory.LinkWhiteStandingUp;
                else if (currentFacing == facing.down)
                    currentSprite = SpriteFactory.LinkWhiteStandingDown;
                else if (currentFacing == facing.right)
                    currentSprite = SpriteFactory.LinkWhiteStandingRight;
                else if (currentFacing == facing.left)
                    currentSprite = SpriteFactory.LinkWhiteStandingLeft;
            }
        }
        public void UseThirdItem()
        {
            currentWeapon = weapon.MagicalSword;
            if (currentStatus == status.standing)
            {
                if (currentFacing == facing.up)
                    currentSprite = SpriteFactory.LinkMagicalSStandingUp;
                else if (currentFacing == facing.down)
                    currentSprite = SpriteFactory.LinkMagicalSStandingDown;
                else if (currentFacing == facing.right)
                    currentSprite = SpriteFactory.LinkMagicalSStandingRight;
                else if (currentFacing == facing.left)
                    currentSprite = SpriteFactory.LinkMagicalSStandingLeft;
            }
        }
        public void UseFourthItem()
        {
            currentWeapon = weapon.MagicalRod;
            if (currentStatus == status.standing)
            {
                if (currentFacing == facing.up)
                    currentSprite = SpriteFactory.LinkMagicalRStandingUp;
                else if (currentFacing == facing.down)
                    currentSprite = SpriteFactory.LinkMagicalRStandingDown;
                else if (currentFacing == facing.right)
                    currentSprite = SpriteFactory.LinkMagicalRStandingRight;
                else if (currentFacing == facing.left)
                    currentSprite = SpriteFactory.LinkMagicalRStandingLeft;
            }
        }
        public void Attack()
        {
            currentStatus = status.attacking;
            if (currentWeapon == weapon.WoodenSword) UseFirstItem();
            
                
            

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
            this.currentWeapon = weapon.None;
            this.currentStatus = status.standing;
            this.currentSprite = SpriteFactory.LinkNoneStandingRight;
        }
    }
}