using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamYoshi.Collisions;

namespace Sprint0
    //Author: Zilin Shao
{
    public class Link : IPlayer
    {
        private int xPosition;
        private int yPosition;
    


        // constructor
        public Link(int x, int y)
        {
            
            xPosition = x;
            yPosition = y;
            
        }


        public void Update()
        {
            State.Update();
           

        }

        public void Draw()
        {
            State.Draw(xPosition, yPosition);
            /*
            foreach (IProjectile p in projectileList)
            {
                p.Draw();
            }
             */
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(xPosition, yPosition, State.GetWidth(), State.GetHeight());
        }

      
        public int getXPosition()
        {
            return xPosition;
        }

        public int getYPosition()
        {
            return yPosition;
        }

        public void setXPosition(int x)
        {
            xPosition = x;
        }

        public void setYPosition(int y)
        {
            yPosition = y;
        }
       

        public void Left()
        {
            //State.Left();
            //Physics.Left();
            //Walk();
        }

        public void Right()
        {
           
        }

        public void Up()
        {
            
        }

        public void Down()
        {

        }

        public void Attack()
        {
        
        }

        public void UseFirstItem()
        {

        }

        public void UseSecondItem()
        {

        }

        public void UseThirdItem()
        {

        }

    }
}
