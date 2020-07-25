using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;

namespace Sprint0.Enemies
{
    public class NZol : AbstractEnemies, IEnemy
    {

        private IPlayer myPlayer;
        private ISprite ZolSprite;
        private int xPosition, yPosition, xDif, yDif;
        bool leftmove = false;
        private Rectangle destinationRec, targetRectangle;

        public NZol(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            ZolSprite = new NZolSprite();
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                ZolSprite.Draw(location, false);
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
            ZolSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, 45, 45);
            return destinationRec;
        }
    }
}