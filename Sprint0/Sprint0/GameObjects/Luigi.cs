using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamYoshi.Collisions;


namespace Sprint0
    //Author: Zilin Shao
    //This class used to test
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

        

        

    }
}
