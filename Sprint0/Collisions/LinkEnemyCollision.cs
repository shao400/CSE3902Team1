using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;

namespace Spriny0.Collisions
{
    class LinkEnemyCollision
    {
        private Player1 myPlayer;

        public LinkEnemyCollision(Player1 player)
        {
            myPlayer = player;
        }

        public void EnemyCollisionTest(Player1 player, List<IEnemy> enemies)
        {
            Rectangle linkRectangle = myPlayer.GetRectangle();
            Rectangle enemyRectangle;
            Rectangle intersectionRectangle;
            //bool enemyKilled = false;
            //Queue<IEnemy> deadEnemies = new Queue<IEnemy>();

            foreach (IEnemy enemy in enemies)
            {
                enemyRectangle = enemy.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, enemyRectangle);

                if (!intersectionRectangle.IsEmpty)
                {
                    if (intersectionRectangle.Width >= intersectionRectangle.Height)
                    {
                        //myPlayer.Hit(); need implementation
                        if (linkRectangle.Y > enemyRectangle.Y && linkRectangle.Y > 0) // from down
                        {
                            if (myPlayer.yAxis < 432 - intersectionRectangle.Height)
                            {
                                myPlayer.yAxis += intersectionRectangle.Height;
                            }
                            else
                            {
                                myPlayer.yAxis = 432;
                            }
                            //myPlayer.yAxis += intersectionRectangle.Height;
                            if (myPlayer.yAxis < 432) { myPlayer.yAxis += 40; } else { myPlayer.yAxis = 432; }
                        }
                        else //from up
                        {
                            if (myPlayer.yAxis > intersectionRectangle.Height)
                            {
                                myPlayer.yAxis -= intersectionRectangle.Height;
                            }
                            else
                            {
                                myPlayer.yAxis = 0;
                            }
                            
                            //myPlayer.xAxis -= intersectionRectangle.Height;
                            if (myPlayer.yAxis > 40) { myPlayer.yAxis -= 40; } else { myPlayer.yAxis = 0; }
                        }
                    }
                    else
                    {
                        if (linkRectangle.X > enemyRectangle.X)//from right
                        {
                            if (myPlayer.xAxis < 752 - intersectionRectangle.Width)
                            {
                                myPlayer.xAxis += intersectionRectangle.Width;
                            }
                            else
                            {
                                myPlayer.xAxis = 752;
                            }
                            //myPlayer.xAxis += intersectionRectangle.Width;
                            if (myPlayer.xAxis < 712) { myPlayer.xAxis += 40; } else { myPlayer.xAxis = 752; }
                        }
                        else //from left
                        {
                            if (myPlayer.xAxis > intersectionRectangle.Width)
                            {
                                myPlayer.xAxis -= intersectionRectangle.Width;
                            }
                            else
                            {
                                myPlayer.xAxis = 0;
                            }
                            //myPlayer.xAxis -= intersectionRectangle.Width;
                            if (myPlayer.xAxis > 40) { myPlayer.xAxis -= 40; } else { myPlayer.xAxis = 0; }
                        }
                    }
                }
            }

            //to be determined by future functions and implementations
            //while (deadEnemies.Count > 0)
            //{
            //    IEnemy enemy = deadEnemies.Dequeue();
            //    enemies.Remove(enemy); 
            //}
            
        }
    }
}
