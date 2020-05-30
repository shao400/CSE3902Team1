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
        private bool isAttacking;
        private bool isTakingDmg;
        private enum facing
        {
            up, down, left, right
        }
        private enum weapon
        {
            none, WoodenSword, WhiteSword, MagicalSword, MagicalRod
        }
        private facing CurrentFacing;
        private weapon CurrentWeapon;
        private ISprite CurrentSprite;
        privare Link myLink;  // Link is a Concrete Class inherit from IPlayer
        private int LeftAndRight;

         public void Update()
        {
            CurrentSprite.Update();
        }

        public P1State(Link link)
        {
            //initial
            CurrentSprite = new Sprites.Link_None_StandingUp_Sprite(); 
            CurrentFacing = facing.up;
            CurrentWeapon = weapon.none;
            isAttacking = false;
            isTakingDmg = false;
            myLink = link;
        }

        public void Stand() 
        {
            if(CurrentWeapon = none)
            {
            
                if(CurrentFacing = up)
                    CurrentSprite = new Sprites.Link_None_StandingUp_Sprite();
                else if(CurrentFacing = down)
                    CurrentSprite = new Sprites.Link_None_StandingDown_Sprite();
                else if(CurrentFacing = left)
                    CurrentSprite = new Sprites.Link_None_StandingLeft_Sprite();
                else if(CurrentFacing = right)
                    CurrentSprite = new Sprites.Link_None_StandingUp_Sprite();
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
