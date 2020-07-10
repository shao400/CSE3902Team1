using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;

//currently not used, since item would not collition with enemy or blocks right now. May update future

namespace Sprint0.Collisions
{
    class ProjectileCollision
    {
        private IProjectile thisProjectile;

        public ProjectileCollision(IProjectile projectile)
        {
            thisProjectile = projectile;
        }
        public void ProjectileCollisionTest(List<IBlock> blocks)
        {
            Rectangle thisRectangle = thisProjectile.GetHitBox();
            Rectangle blockRectangle;
            Rectangle intersectionRectangle;
            foreach (IBlock block in blocks)
            {

                blockRectangle = block.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(thisRectangle, blockRectangle);
                Console.WriteLine(thisRectangle.ToString());
                if (!intersectionRectangle.IsEmpty)
                {
                    // check the collison occuring direction
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height)) // from up or down
                    {
                        if (thisRectangle.Y > blockRectangle.Y) // from down
                        {
                            thisProjectile.explo(1);
                        }
                        else //from up
                        {
                            thisProjectile.explo(1);
                        }
                    }
                    else //from right or left
                    {
                        if (thisRectangle.X > blockRectangle.X)//from right
                        {
                            thisProjectile.explo(1);
                            Console.WriteLine("xxx");
                        }
                        else //from left
                        {
                            thisProjectile.explo(1);
                            Console.WriteLine("xxxxxxxxx");
                        }
                    }
                    break;//once link has collision with one block, no need to detect other blocks
                
            }
            }
        }
    }
}
