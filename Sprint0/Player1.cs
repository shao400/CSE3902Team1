using Microsoft.Xna.Framework;
using Sprint0.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public Player1(int x, int y, int width_g, int height_g) 
        {
            states = new P1State();
            xAxis = x;
            yAxis = y;
            width = width_g;
            height = height_g;
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
                xAxis -= 1;
            }
            else if (currentFacing.CompareTo("right") == 0 && currentStatus.CompareTo("walking") == 0)
            {
                xAxis += 1;
            }
            else if (currentFacing.CompareTo("down") == 0 && currentStatus.CompareTo("walking") == 0)
            {
                yAxis += 1;
            }
            else if (currentFacing.CompareTo("up") == 0 && currentStatus.CompareTo("walking") == 0)
            {
                yAxis -= 1;
            }
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
            xAxis += 10;
            
        }
        public void Left()
        {
            states.left();
            xAxis -= 10;
            
        }

        public void Up()
        {
            states.Up();
            yAxis -= 10;
            
        }

        public void Down()
        {
            states.Down();
            yAxis += 10;
            

        }
        public void Stand()
        {
            states.Stand();
        }
        public void Attack()
        {
            states.Attack();
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
            //states.UseThirdItem();
        }
        public void UseFourthItem()
        {
            states.UseFourthItem();
        }


    }
}
