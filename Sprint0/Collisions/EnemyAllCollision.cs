using Microsoft.Xna.Framework;
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
                   
                    if (myRectangle.X <= blockRectangle.X)
                    {
                        if (myRectangle.Y >= blockRectangle.Y)
                        {
                            myEnemy.Reverse(intersectionRectangle.Width);
                        }
                    }
                    else if (myRectangle.X >= blockRectangle.X)
                    {
                        if (myRectangle.Y >= blockRectangle.Y)
                        {
                            myEnemy.Reverse(intersectionRectangle.Width);
                        }
                    }
                }


            }
        }

        public void EnemyCollisionTest(IList<IEnemy> enemies)
        {
            Rectangle myRectangle = myEnemy.GetRectangle();
            Rectangle enemyRectangle;
            Rectangle intersectionRectangle;

            /*wait for implementation as we still have only one enemy*/

        }
    }
}