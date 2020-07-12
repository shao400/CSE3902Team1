using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.HUD;
using Sprint0.Interfaces;
using Sprint0.Items;
using Sprint0.Player;

namespace Sprint0.Collisions
{
    class LinkItemCollision
    {
        private Player1 myPlayer;
        private HeartContainer heart = new HeartContainer(1, 1);
        private Triforce triforce;

        public LinkItemCollision(Player1 player)
        {
            myPlayer = player;
        }


        public void ItemCollision(List<IItem> items)
        {
            Rectangle linkRectangle = myPlayer.GetRectangle();
            Rectangle itemRectangle;
            Rectangle intersectionRectangle;
            foreach (IItem item in items)
            {
                itemRectangle = item.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, itemRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    if (item.GetType() == heart.GetType() && !item.isPickedUp())
                    {
                        myPlayer.getHealed();
                    }
                    if (item.GetType() == triforce.GetType() && !item.isPickedUp())
                    {
                        myPlayer.winGame();
                    }

                    // check the collison occuring direction
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height)) // from up or down
                    {
                        if (linkRectangle.Y > itemRectangle.Y) // from down
                        {
                            item.PickedUp();
                        }
                        else //from up
                        {
                            item.PickedUp();
                        }
                    }
                    else //from right or left
                    {
                        if (linkRectangle.X > itemRectangle.X)//from right
                        {
                            item.PickedUp();
                        }
                        else //from left
                        {
                            item.PickedUp();
                        }
                    }
                }
            }
        }
    }
}







