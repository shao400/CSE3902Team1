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
        public void ProjectileEnemiesCollisionTest(List<IEnemy> enemies)
        {
            Rectangle thisRectangle = thisProjectile.GetHitBox();
            Rectangle enemyRectangle;
            Rectangle intersectionRectangle;
            foreach (IEnemy enemy in enemies)
            {

                enemyRectangle = enemy.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(thisRectangle, enemyRectangle);
                if (!intersectionRectangle.IsEmpty && enemy.GetHealth() > 0)
                {
                    enemy.Damaged();
                    // check the collison occuring direction
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height)) // from up or down
                    {

                        if (thisRectangle.Y > enemyRectangle.Y) // from down
                        {
                            if (thisProjectile.IsExplode() == 0)
                            {
                                thisProjectile.explo(1);
                               
                            }

                        }
                        else //from up
                        {
                            if (thisProjectile.IsExplode() == 0)
                            {
                                thisProjectile.explo(1);
                            }
                        }
                    }
                    else //from right or left
                    {
                        if (thisRectangle.X > enemyRectangle.X)//from right
                        {
                            if (thisProjectile.IsExplode() == 0)
                            {
                                thisProjectile.explo(1);
                            }
                        }
                        else //from left
                        {
                            if (thisProjectile.IsExplode() == 0)
                            {
                                thisProjectile.explo(1);
                                Console.WriteLine("xxxxx");
                            }
                        }
                    }
                    break;//once link has collision with one block, no need to detect other blocks

                }
            }
        }
        public void ProjectileBlocksCollisionTest(List<IBlock> blocks)
        {
            Rectangle thisRectangle = thisProjectile.GetHitBox();
            Rectangle blockRectangle;
            Rectangle intersectionRectangle;
            foreach (IBlock block in blocks)
            {

                blockRectangle = block.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(thisRectangle, blockRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    // check the collison occuring direction
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height)) // from up or down
                    {
                        if (thisRectangle.Y > blockRectangle.Y) // from down
                        {
                            if (thisProjectile.IsExplode() == 0)
                            {
                                thisProjectile.explo(1);
                            }
                            
                        }
                        else //from up
                        {
                            if (thisProjectile.IsExplode() == 0)
                            {
                                thisProjectile.explo(1);
                            }
                        }
                    }
                    else //from right or left
                    {
                        if (thisRectangle.X > blockRectangle.X)//from right
                        {
                            if (thisProjectile.IsExplode() == 0)
                            {
                                thisProjectile.explo(1);
                            }
                        }
                        else //from left
                        {
                            if (thisProjectile.IsExplode() == 0)
                            {
                                thisProjectile.explo(1);
                                Console.WriteLine("xxxxx");
                            }
                        }
                    }
                    break;//once link has collision with one block, no need to detect other blocks
                
            }
            }
        }
    }
}
