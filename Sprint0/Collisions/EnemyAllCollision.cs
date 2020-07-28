using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//currently not used, since enemy would not collition with items or blocks right now. May update future
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
        public List<Boolean> BlockCollisionTest(IList<IBlock> blocks)
        {
            Rectangle myRectangle = myEnemy.GetRectangle();
            Rectangle blockRectangle;
            Rectangle intersectionRectangle;
            Boolean UpDownCollid = false;
            Boolean LeftRightCollid = false;
            foreach (IBlock block in blocks)
            {

                blockRectangle = block.GetRectangle();

                intersectionRectangle = Rectangle.Intersect(myRectangle, blockRectangle);

                if (!intersectionRectangle.IsEmpty)
                {
                    // check the collison occuring direction
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height)) // from up or down
                    {
                        UpDownCollid = true;
                        if (myRectangle.Y > blockRectangle.Y) // from down
                        {
                            myEnemy.xReverse(intersectionRectangle.Height, true);
                            //myEnemy.x += intersectionRectangle.Height;
                        }
                        else //from up
                        {
                            myEnemy.xReverse(intersectionRectangle.Height, false);
                            //myEnemy.yAxis -= intersectionRectangle.Height;
                        }
                    }
                    else //from right or left
                    {
                        LeftRightCollid = true;
                        if (myRectangle.X > blockRectangle.X)//from right
                        {
                            myEnemy.yReverse(intersectionRectangle.Height, true);
                            //myEnemy.xAxis += intersectionRectangle.Width;
                        }
                        else //from left
                        {
                            myEnemy.yReverse(intersectionRectangle.Height, false);
                            //myEnemy.xAxis -= intersectionRectangle.Width;
                        }
                    }
                }
            }
            List<Boolean> UDLRCollid = new List<bool>();
            UDLRCollid.Add(UpDownCollid);
            UDLRCollid.Add(LeftRightCollid);
            return UDLRCollid;
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
    