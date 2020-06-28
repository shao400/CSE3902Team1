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
        private Heart heart = new Heart(1, 1);

        public LinkItemCollision(Player1 player)
        {
            myPlayer = player;
        }


        public void ItemCollision(Player1 player, List<IItem> items)
        {
            Rectangle linkRectangle = myPlayer.GetRectangle();
            Rectangle itemRectangle;
            Rectangle intersectionRectangle;
            //List<IItem> holdItems=new List<IItem>();
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
                    // check the collison occuring direction
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height)) // from up or down
                    {
                        if (linkRectangle.Y > itemRectangle.Y) // from down
                        {
                            //myPlayer.yAxis += intersectionRectangle.Height;
                            item.PickedUp();
                        }
                        else //from up
                        {
                           // myPlayer.yAxis -= intersectionRectangle.Height;
                            item.PickedUp();
                        }
                    }
                    else //from right or left
                    {
                        if (linkRectangle.X > itemRectangle.X)//from right
                        {
                            //myPlayer.xAxis += intersectionRectangle.Width;
                            item.PickedUp();
                        }
                        else //from left
                        {
                            //myPlayer.xAxis -= intersectionRectangle.Width;
                            item.PickedUp();
                        }
                    }
                }
            }
        }
    }
}







