﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;

namespace Sprint0.Collisions
{
    class LinkEnemyCollision
    {
        private Player1 myPlayer;

        public LinkEnemyCollision(Player1 player)
        {
            myPlayer = player;
        }

        public void EnemyCollisionTest(List<IEnemy> enemies)
        {
            Rectangle linkRectangle = myPlayer.GetRectangle();
            Rectangle enemyRectangle;
            Rectangle intersectionRectangle;
            

            foreach (IEnemy enemy in enemies)
            {
                enemyRectangle = enemy.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, enemyRectangle);

                if (!intersectionRectangle.IsEmpty)
                {
                    myPlayer.takeDmg();
                    if (intersectionRectangle.Width >= intersectionRectangle.Height)
                    {                     
                        if (linkRectangle.Y > enemyRectangle.Y && linkRectangle.Y > 0) // from down
                        {

                            if (myPlayer.yAxis < 552 - intersectionRectangle.Height)
                            {
                                myPlayer.yAxis += intersectionRectangle.Height;
                            }
                            else
                            {
                                myPlayer.yAxis = 552;
                            }
                            if (myPlayer.yAxis < 512) { myPlayer.yAxis += 40; } else { myPlayer.yAxis = 552; }
                            
                        }
                        else if (linkRectangle.Y < enemyRectangle.Y) //from up
                        {
                            if (myPlayer.yAxis > intersectionRectangle.Height)
                            {
                                myPlayer.yAxis -= intersectionRectangle.Height;
                            }
                            else
                            {
                                myPlayer.yAxis = 264;
                            }
                            
                            if (myPlayer.yAxis > 304) { myPlayer.yAxis -= 40; } else { myPlayer.yAxis = 264; }
                        }
                    }
                    else
                    {
                        if (linkRectangle.X > enemyRectangle.X)//from right
                        {
                            if (myPlayer.xAxis < 624 - intersectionRectangle.Width)
                            {
                                myPlayer.xAxis += intersectionRectangle.Width;
                            }
                            else
                            {
                                myPlayer.xAxis = 624;
                            }
                            if (myPlayer.xAxis < 584) { myPlayer.xAxis += 40; } else { myPlayer.xAxis = 624; }
                        }
                        else //from left
                        {
                            if (myPlayer.xAxis > intersectionRectangle.Width)
                            {
                                myPlayer.xAxis -= intersectionRectangle.Width;
                            }
                            else
                            {
                                myPlayer.xAxis = 96;
                            }
                            if (myPlayer.xAxis > 136) { myPlayer.xAxis -= 40; } else { myPlayer.xAxis = 96; }
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
