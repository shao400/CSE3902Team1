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
using Spriny0.Collisions;

// Author: Lufei Ouyang
namespace Sprint0.Player
{
    public class Player1 : IPlayer
    {
        private P1State states;
        public int xAxis;
        public int yAxis;
        private int width;
        private int height;
        private string currentFacing, currentStatus;
        private LinkBlockCollision linkBlockCollision;
        private LinkItemCollision linkItemCollision;
        private LinkEnemyCollision linkEnemyCollision;

        public Player1(int x, int y, int width_g, int height_g) 
        {
            states = new P1State();
            xAxis = x;
            yAxis = y;
            width = width_g;
            height = height_g;

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
            if (currentFacing.CompareTo("left") == 0 && currentStatus.CompareTo("walking") == 0)
            {
                if(xAxis > 96)
                {
                    xAxis -= 5;
                }    
            }
            else if (currentFacing.CompareTo("right") == 0 && currentStatus.CompareTo("walking") == 0)
            {
                if (xAxis < 624)
                {
                    xAxis += 5;
                }
            }
            else if (currentFacing.CompareTo("down") == 0 && currentStatus.CompareTo("walking") == 0)
            {
                if (yAxis < 552)
                {
                    yAxis += 5;
                }                
            }
            else if (currentFacing.CompareTo("up") == 0 && currentStatus.CompareTo("walking") == 0)
            {
                if (yAxis > 264)
                {
                    yAxis -= 5;
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
        }
        public void takeDmg()
        {
            states.takeDmg();
            states.decreaseLife();
        }
        public void Player_Reset()
        {
            states.State_Reset();
            xAxis = 100;
            yAxis = 100;
        }
        public void UseFirstItem()
        {
            states.UseFirstItem();
        }
        public void UseSecondItem()
        {
            states.UseSecondItem();
        }
        public void UseThirdItem()
        {
            states.UseThirdItem();
        }
        public void UseFourthItem()
        {
            states.UseFourthItem();
        }

        //collision tests
        public void BlockCollisionTest(List<IBlock> blocks)
        {
            linkBlockCollision.BlockCollision(this, blocks);
        }

        public void EnemyCollisionTest(List<IEnemy> enemies)
        {
            linkEnemyCollision.EnemyCollisionTest(this, enemies);
        }

        public void ItemCollisionTest(List<IItem> items)
        {
            linkItemCollision.ItemCollision(this, items);
        }
    }
}
