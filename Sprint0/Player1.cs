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
        public Player1(int x, int y, int width_g, int height_g) //Ä¿Ç°²»ÖªµÀ»¹ÐèÒªÊ²Ã´paramet 
        {
            states = new P1State();
            xAxis = x;
            yAxis = y;
            width = width_g;
            height = height_g;
        }
        public void Update()
        {

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
        }
        public void Left()
        {
            states.left();
        }

        public void Up()
        {
            states.Up();
        }

        public void Down()
        {
            states.Down();
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



    }
}
