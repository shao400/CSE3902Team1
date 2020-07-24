using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;

namespace Sprint0.Enemies
{
    public class NGoriya : AbstractEnemies, IEnemy
    {

        private IPlayer myPlayer;
        private ISprite GoriyaSprite;
        private int xPosition, yPosition, xDif, yDif;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec, targetRectangle;
        

        public NGoriya(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            GoriyaSprite = new NGoriyaSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                GoriyaSprite.Draw(location, false);
            }
            
        }

        public override void Update()
        {
            targetRectangle = myPlayer.GetRectangle();
            xDif = targetRectangle.X - xPosition;
            yDif = targetRectangle.Y - yPosition;
            if (Math.Abs(xDif) > Math.Abs(yDif))
            {
                if (xDif > 0) xPosition += 5;
                else xPosition -= 5;
            }
            else
            {
                if (yDif > 0) yPosition += 5;
                else yPosition -= 5;
            }
            
            if (destinationRec.X > 627) backmove = true;
            if (destinationRec.X < 96) backmove = false;
            GoriyaSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, 45, 45);
            return destinationRec;                                  
        }
    }
}