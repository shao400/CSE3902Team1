using System;
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

        public int CollisionTest(Player1 player, List<IEnemy> enemies)
        {
            Rectangle linkRectangle = myPlayer.GetRectangle();
            Rectangle enemyRectangle;
            Rectangle intersectionRectangle;
            bool enemyKilled = false;
            Queue<IEnemy> deadEnemies = new Queue<IEnemy>();

            foreach (IEnemy enemy in enemies)
            {
                enemyRectangle = enemy.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, enemyRectangle);

                if (!intersectionRectangle.IsEmpty)
                {
                    if (intersectionRectangle.Width >= intersectionRectangle.Height)
                    {
                        //myPlayer.Bounce(); need implementation
                        enemyKilled = true;
                        deadEnemies.Enqueue(enemy);
                    }
                    else
                    {
                        //myPlayer.Hit(); need implementation
                    }
                }
            }

            while (deadEnemies.Count > 0)
            {
                IEnemy enemy = deadEnemies.Dequeue();
                enemies.Remove(enemy);
            }
            return 0;
        }
    }
}
