using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;

namespace Sprint0.Collisions
{
    public class EnemyAllCollision
    {

        private IEnemy myEnemy;

        public EnemyAllCollision(IEnemy enemy)
        {
            myEnemy = enemy;
        }

        /*Will Return true if collid in Left Right Direction*/
        public void BlockCollisionTest(IList<IBlock> blocks)
        {
            Rectangle myRectangle = myEnemy.GetRectangle();
            Rectangle blockRectangle;
            Rectangle intersectionRectangle;

            foreach (IBlock block in blocks)
            {

                blockRectangle = block.GetRectangle();

                intersectionRectangle = Rectangle.Intersect(myRectangle, blockRectangle);

                if (!intersectionRectangle.IsEmpty)
                {
                    // check the collison occuring direction
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height)) // from up or down
                    {
                        if (myRectangle.Y > blockRectangle.Y) myEnemy.yReverse(intersectionRectangle.Height, true);
                        else myEnemy.yReverse(intersectionRectangle.Height, false);                        
                    }
                    else //from right or left
                    {
                        if (myRectangle.X > blockRectangle.X) myEnemy.xReverse(intersectionRectangle.Width, true);                        
                        else myEnemy.xReverse(intersectionRectangle.Width, false);
                        
                    }
                }
            }
        }


        public Boolean BlockCollisionDetect(List<IBlock> blocks, int x, int y, int size)
        {
            Rectangle blockRectangle;
            Rectangle myRectangle = new Rectangle(x, y, size, size);
            Rectangle intersectionRectangle;
            Boolean collid = false;
            foreach (IBlock block in blocks)
            {
                blockRectangle = block.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(myRectangle, blockRectangle);
                if (!intersectionRectangle.IsEmpty) collid = true;                           
            }
            return collid;
        }



    }
}
    