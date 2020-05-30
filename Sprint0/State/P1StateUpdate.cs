using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.State
{
    class P1State
    {
        private ISprite currentSprite;
        private bool isAttacking;
        private bool isTakingDmg;
        private enum facing
        {
            up, down, left, right
        }
        private enum weapon
        {
            None, WoodenSword, WhiteSword, MagicalSword, MagicalRod
        }


        private facing currentFacing;
        private weapon currentWeapon;
        


        //privare Link myLink;  
        // Link is a Concrete Class inherit from IPlayer
        //private int LeftAndRight;

         public void Update()
        {
            currentSprite.Update();
        }

        public P1State(Link link)// 可能不需要parameter因为P1里面有P1State，P1State里面也不需要P1
        {
            //initial
            currentSprite = new Sprites.Link_None_StandingUp_Sprite(); 
            currentFacing = facing.up;
            currentWeapon = weapon.none;
            isAttacking = false;
            isTakingDmg = false;
            myLink = link;
        }

        public void Stand() 
        {
            if(weapon = weapon.none)
            {
            
                if(currentFacing = facing.up)
                    currentSprite = new Sprite()();
                else if(currentFacing = facing.down)
                    currentSprite = new Sprites.Link_None_StandingDown_Sprite();
                else if(currentFacing = facing.left)
                    currentSprite = new Sprites.Link_None_StandingLeft_Sprite();
                else if(currentFacing = facing.right)
                    currentSprite = new Sprites.Link_None_StandingUp_Sprite();
            }
            else if (CurrentWeapon = WoodenSword)
            {
            //有个问题，Link有剑的时候平时走路能不能看到？
            }
            
        }

        public void Walk() // copy Stand, add sprites
        {
            if(isTakingDmg = false && isAttacking = false)
            {
                
            }
        }

        public void Attack() // 一次攻击需要4个sprites
            //TODO call multi sprites, use vector
        {
            if(CurrentWeapon != none)
            {
                if(CurrentWeapon = WoodenSword)
                    CurrentSprite = new Sprites.Link_Wooden_Attack1_Sprite(); 
                else if(CurrentWeapon = WhiteSword)
                    CurrentSprite = new Sprites.Link_White_Attack1_Sprite();
                else if(CurrentWeapon = MagicalSword)
                    CurrentSprite = new Sprites.Link_Magical_Attack1_Sprite();
                else if(CurrentWeapon = MagicalRod)
                    CurrentSprite = new Sprites.Link_Rod_Attack1_Sprite();
            }
        }

        private void resetSprite()
        {
            CurrentFacing = up;
            CurrentSprite = new Sprites.Link_None_Standing1_Sprite();
            CurrentWeapon = none;
        }
    }
}
