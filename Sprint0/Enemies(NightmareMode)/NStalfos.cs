using System;
using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.Player;

namespace Sprint0.Enemies
{
    public class NStalfos : AbstractEnemies, IEnemy
    {

        private IPlayer myPlayer;
        private ISprite StalfosSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec, targetRectangle;
        private int xDif, yDif;
        private bool leftmove = false;
        public NStalfos(int x, int y, Player1 link)
        {
            myPlayer = link;
            xPosition = x;
            yPosition = y;
            StalfosSprite = new NStalfosSprite();
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                StalfosSprite.Draw(location, leftmove);
            }
        }

        public override void Update()
        {

            targetRectangle = myPlayer.GetRectangle();
            xDif = targetRectangle.X - xPosition;
            yDif = targetRectangle.Y - yPosition;
            if (Math.Abs(xDif) > Math.Abs(yDif))
            {
                if (xDif > 0) { xPosition += 3; leftmove = false; }
                else { xPosition -= 3; leftmove = true; }
            }
            else
            {
                if (yDif > 0) yPosition += 3;
                else yPosition -= 3;
            }


            StalfosSprite.Update();
        }

        /*private void Flash()
        {
            //A counter needed
            targetRectangle = _link.GetRectangle();
            xPosition = targetRectangle.X;
            yPosition = targetRectangle.Y;
        }*/

        public override Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, 45, 45);
            return destinationRec;
        }
    }
}