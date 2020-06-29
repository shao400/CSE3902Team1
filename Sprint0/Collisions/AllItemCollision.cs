using Microsoft.Xna.Framework;
using Sprint0.Interfaces;

//currently not used, since item would not collition with enemy or blocks right now. May update future
 
namespace Sprint0.Collisions
{
    class AllItemCollision
    {
        private IItem thisItem;

        public AllItemCollision(IItem item)
        {
            thisItem = item;
        }
        public void AllItemCollisionTest()
        {
            Rectangle thisRectangle = thisItem.GetRectangle(IList <IBlock> blocks);
            Rectangle blockRectangle;
            Rectangle intersectionRectangle;
            foreach (IBlock block in blocks)
            {

                blockRectangle = block.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(thisRectangle, blockRectangle);

                if (!intersectionRectangle.IsEmpty)
                {
                    if (intersectionRectangle.Width >= intersectionRectangle.Height)
                    {

                    }

                    else if (thisRectangle.X < blockRectangle.X)
                    {

                    }
                    else if (thisRectangle.X > blockRectangle.X)
                    {

                    }
                }
            }
        }
    }
}
