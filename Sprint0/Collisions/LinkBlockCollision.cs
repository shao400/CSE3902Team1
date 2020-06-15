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
    class LinkBlockCollision
    {
        private Player1 myPlayer;

        public LinkBlockCollision(Player1 player)
        {
            myPlayer = player;
        }


        public void CollisionItem(Player1 player, List<IBlock> blocks)
        {
            Rectangle linkRectangle = myPlayer.GetRectangle();
            Rectangle blockRectangle;
            Rectangle intersectionRectangle;

            foreach (IBlock block in blocks)
            {
                blockRectangle = block.GetRectangle();             
                intersectionRectangle = Rectangle.Intersect(linkRectangle, blockRectangle);

                if (!intersectionRectangle.IsEmpty)
                {
                    // check the collison occuring direction
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height)) // from up or down
                    {
                        if (linkRectangle.Y > blockRectangle.Y) // from down
                        {
                            linkRectangle.Y += intersectionRectangle.Height;
                        }
                        else //from up
                        {
                            linkRectangle.Y -= intersectionRectangle.Height;
                        }
                    }
                    else //from right or left
                    {
                        if (linkRectangle.X > blockRectangle.X)//from right
                        {
                            linkRectangle.X += intersectionRectangle.Width;
                        }
                        else //from left
                        {
                            linkRectangle.X -= intersectionRectangle.Width;
                        }
                    }
                }
            }
        }
    }
}
 


