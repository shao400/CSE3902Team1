using Microsoft.Xna.Framework;
using Sprint0.Commands;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using Sprint0.UtilityClass;
using Sprint0.Player;
using Sprint0.Items;


namespace Sprint0.Collisions
{
    class ProjectileCollision
    {
        private IProjectile thisProjectile;
        private IPlayer myPlayer;
        public ProjectileCollision(IProjectile projectile, IPlayer link)
        {
            thisProjectile = projectile;
            myPlayer = link;
            myPlayer = link;
        }
        public void ProjectileEnemiesCollisionTest(List<IEnemy> enemies, Sound s)
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
                    if (thisProjectile.IsExplode() == 0 && thisProjectile.Type() != StringHolder.Bomb)
                    {
                        enemy.Damaged();
                        thisProjectile.setExplo(1);
                        if (enemy.GetHealth() == 0)
                        {
                            myPlayer.GetGame().currentRoom.itemList.Add(new Ruppy(enemy.GetRectangle().X, enemy.GetRectangle().Y));
                            myPlayer.GetGame().NcurrentRoom.itemList.Add(new Ruppy(enemy.GetRectangle().X, enemy.GetRectangle().Y));
                            s.enemyDie();
                        }
                        else s.enemyHit();                        
                    } 
                    else if (thisProjectile.Type() == StringHolder.Bomb && thisProjectile.IsExplode() == 1)
                    {
                        for (int i = 0; i< enemy.GetHealth(); i++)
                        {
                            enemy.Damaged();
                        }
                        if (enemy.GetHealth() == 0)
                        {
                            myPlayer.GetGame().currentRoom.itemList.Add(new Ruppy(enemy.GetRectangle().X, enemy.GetRectangle().Y));
                            myPlayer.GetGame().NcurrentRoom.itemList.Add(new Ruppy(enemy.GetRectangle().X, enemy.GetRectangle().Y));
                            s.enemyDie();
                        }
                        else s.enemyHit();                                            
                    }
                    else if (thisProjectile.IsExplode() == IntegerHolder.Three )
                    {
                        enemy.Damaged();
                        thisProjectile.setExplo(IntegerHolder.Three);
                        if (enemy.GetHealth() == 0)
                        {
                            myPlayer.GetGame().currentRoom.itemList.Add(new Ruppy(enemy.GetRectangle().X, enemy.GetRectangle().Y));
                            myPlayer.GetGame().NcurrentRoom.itemList.Add(new Ruppy(enemy.GetRectangle().X, enemy.GetRectangle().Y));
                            s.enemyDie();
                        }
                        else s.enemyHit();                                              
                    }                    
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
                if (!intersectionRectangle.IsEmpty && block.getType() != StringHolder.WaterType && thisProjectile.Type() != StringHolder.Bomb)
                {
                    if (thisProjectile.IsExplode() == 0) thisProjectile.setExplo(1);                                                                             
                    break;//once link has collision with one block, no need to detect other blocks                
                }
            }
        }

        public void ProjectileLinkCollisionTest()
        {
            Rectangle thisRectangle = thisProjectile.GetHitBox();
            Rectangle linkRectangle;
            Rectangle intersectionRectangle;
      
            linkRectangle = myPlayer.GetRectangle();
            intersectionRectangle = Rectangle.Intersect(thisRectangle, linkRectangle);
            if (!intersectionRectangle.IsEmpty && thisProjectile.IsExplode() == 0)
            {
                myPlayer.GetSound().linkHurt();
                myPlayer.takeDmg(1);
                thisProjectile.setExplo(1);                  
            }           
        }
    }
}
