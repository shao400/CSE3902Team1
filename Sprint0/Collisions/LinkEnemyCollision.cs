using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.Enemies;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.UtilityClass;

namespace Sprint0.Collisions
{
    class LinkEnemyCollision
    {
        private Player1 myPlayer;
        private Oldman oldman;
        public LinkEnemyCollision(Player1 player)
        {
            myPlayer = player;
            oldman = new Oldman(0, 0, player);
        }

        public void EnemyCollisionTest(List<IEnemy> enemies, Sound s)
        {
            Rectangle linkRectangle = myPlayer.GetRectangle();
            Rectangle enemyRectangle;
            Rectangle intersectionRectangle;
            

            foreach (IEnemy enemy in enemies)
            {
                enemyRectangle = enemy.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, enemyRectangle);

                if (!intersectionRectangle.IsEmpty && enemy.GetHealth() >0)
                {
                    //Special Case for Oldman
                    if (enemy.GetType() == oldman.GetType() && oldman.health!=0)
                    {
                        myPlayer.takeDmg(IntegerHolder.Four);
                        enemy.Damaged();
                        if (enemy.GetHealth() == 0)
                        {
                            s.enemyDie();
                        }
                        else
                        {
                            s.enemyHit();
                        }                   
                    }
                    //Normal Cases
                    myPlayer.takeDmg(1);
                    if (intersectionRectangle.Width >= intersectionRectangle.Height)
                    {                     
                        if (linkRectangle.Y > enemyRectangle.Y && linkRectangle.Y > 0) // from down
                        {

                            if (myPlayer.yAxis < IntegerHolder.FiveFiveTwo - intersectionRectangle.Height)
                            {
                                myPlayer.yAxis += intersectionRectangle.Height;
                            }
                            else
                            {
                                myPlayer.yAxis = IntegerHolder.FiveFiveTwo;
                            }
                            if (myPlayer.yAxis < IntegerHolder.FiveOneTwo) { myPlayer.yAxis += IntegerHolder.Fourty; } else { myPlayer.yAxis = IntegerHolder.FiveFiveTwo; }
                            
                        }
                        else if (linkRectangle.Y < enemyRectangle.Y) //from up
                        {
                            if (myPlayer.yAxis > intersectionRectangle.Height)
                            {
                                myPlayer.yAxis -= intersectionRectangle.Height;
                            }
                            else
                            {
                                myPlayer.yAxis = IntegerHolder.TwoSixFour;
                            }
                            
                            if (myPlayer.yAxis > 304) { myPlayer.yAxis -= IntegerHolder.Fourty; } else { myPlayer.yAxis = IntegerHolder.TwoSixFour; }
                        }
                    }
                    else
                    {
                        if (linkRectangle.X > enemyRectangle.X)//from right
                        {
                            if (myPlayer.xAxis < IntegerHolder.SixTwoFour - intersectionRectangle.Width)
                            {
                                myPlayer.xAxis += intersectionRectangle.Width;
                            }
                            else
                            {
                                myPlayer.xAxis = IntegerHolder.SixTwoFour;
                            }
                            if (myPlayer.xAxis < 584) { myPlayer.xAxis += IntegerHolder.Fourty; } else { myPlayer.xAxis = IntegerHolder.SixTwoFour; }
                        }
                        else //from left
                        {
                            if (myPlayer.xAxis > intersectionRectangle.Width)
                            {
                                myPlayer.xAxis -= intersectionRectangle.Width;
                            }
                            else
                            {
                                myPlayer.xAxis = IntegerHolder.NinetySix;
                            }
                            if (myPlayer.xAxis > 136) { myPlayer.xAxis -= IntegerHolder.Fourty; } else { myPlayer.xAxis = IntegerHolder.NinetySix; }
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
