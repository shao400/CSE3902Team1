using Microsoft.Xna.Framework;
using Sprint0.Collisions;
using Sprint0.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Sprint0.Interfaces;
using Microsoft.Xna.Framework.Audio;
using Sprint0.HUD;

// Author: Lufei Ouyang
namespace Sprint0.Player
{
    public class Player1 : IPlayer
    {
        public P1State states;
        public int xAxis;
        public int yAxis;
        private int width;
        private int height;
        private string currentFacing, currentStatus;
        private LinkBlockCollision linkBlockCollision;
        private LinkItemCollision linkItemCollision;
        private LinkEnemyCollision linkEnemyCollision;
        private Sound sound;
        private int hp;

        public Player1(int x, int y, int widthG, int heightG, Sound s) 
        {
            states = new P1State();
            xAxis = x;
            yAxis = y;
            width = widthG;
            height = heightG;
            sound = s;
            hp = 2;
            linkBlockCollision = new LinkBlockCollision(this);
            linkItemCollision = new LinkItemCollision(this);
            linkEnemyCollision = new LinkEnemyCollision(this);
        }

        public bool isTakingDmg()
        {
            return currentStatus == "takingDmg";
        }
        public ISprite getSprite()
        {
            return states.currentSprite;
        }
        public void Update()
        {
            currentFacing = states.GetCurrentFacing();
            currentStatus = states.GetCurrentStatus();
            states.Update();
            if (string.Compare(currentStatus,"walking", new StringComparison()) == 0 && string.Compare(currentFacing, "left", new StringComparison()) == 0)
            {
                if(xAxis > 96)
                {
                    xAxis -= 3;
                }    
            }
            else if (string.Compare(currentFacing, "right", new StringComparison()) == 0 && string.Compare(currentStatus, "walking", new StringComparison()) == 0)
            {
                if (xAxis < 624)
                {
                    xAxis += 3;
                }
            }
            else if (string.Compare(currentFacing, "down", new StringComparison()) == 0 && string.Compare(currentStatus, "walking", new StringComparison()) == 0)
            {
                if (yAxis < 552)
                {
                    yAxis += 3;
                }                
            }
            else if (string.Compare(currentFacing, "up", new StringComparison()) == 0 && string.Compare(currentStatus, "walking", new StringComparison()) == 0)
            {
                if (yAxis > 264)
                {
                    yAxis -= 3;
                }                
            }

            //more border restrictions
            if (xAxis < 96) xAxis = 96;
            if (xAxis > 624) xAxis = 624;
            if (yAxis < 264) yAxis = 264;
            if (yAxis > 552) yAxis = 552;
        }
        public void Draw()
        {
            //states.Draw();
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle(xAxis, yAxis, width, height);
        }
        public void Right()
        {
            states.right();
           // xAxis += 10;
            
        }
        public void Left()
        {
            states.left();
            //xAxis -= 10;
            
        }
        public void Up()
        {
            states.Up();
            //yAxis -= 10;
            
        }
        public void Down()
        {
            states.Down();
            //yAxis += 10;
            
        }
        public void Stand()
        {
            states.Stand();
        }
        public void Attack()
        {
            states.Attack();
            sound.swordSlash();
        }
        public void takeDmg()
        {
            sound.linkHurt();
            states.takeDmg();
            if (hp>0)
            {
                hp--;
            }
        }

        public void getHealed()
        {
            if (hp<2)
            {
                hp++;
            }
        }
        public void PlayerReset()
        {
            states.StateReset();
            xAxis = 100;
            yAxis = 100;
            hp = 2;
        }

        public int linkHp()
        {
            return hp;
        }
        public void UseFirstItem()
        {
            sound.swordSlash();
            states.UseFirstItem();
        }
        public void UseSecondItem()
        {
            sound.swordSlash();
            states.UseSecondItem();
        }
        public void UseThirdItem()
        {
            sound.swordSlash();
            states.UseThirdItem();
        }
        public void UseFourthItem()
        {
            sound.magicRod();
            states.UseFourthItem();
        }

        //collision tests
        public void BlockCollisionTest(List<IBlock> blocks)
        {
            linkBlockCollision.BlockCollision(blocks);
        }

        public void EnemyCollisionTest(List<IEnemy> enemies)
        {
            linkEnemyCollision.EnemyCollisionTest(enemies);
        }

        public void ItemCollisionTest(List<IItem> items)
        {
            linkItemCollision.ItemCollision(items);
        }
    }
}
