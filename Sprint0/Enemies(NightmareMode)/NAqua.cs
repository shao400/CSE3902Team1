using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;
using Sprint0.Collisions;

namespace Sprint0.Enemies
{
    public class NAqua : NAbstractEnemies, INEnemy 
    {

        private IPlayer myPlayer;
        private ISprite AquaSprite;
        private int xPosition, yPosition, xDif, yDif;
        bool leftmove = false;
        private Rectangle destinationRec, targetRectangle;
        private EnemyAllCollision enemyAllCollision;
        public NAqua(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            AquaSprite = new NAquaSprite();
            destinationRec = new Rectangle(x, y, 45, 60);
            enemyAllCollision = new EnemyAllCollision(this);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                AquaSprite.Draw(location, leftmove);
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
            if (xPosition > 627) leftmove = true;
            if (xPosition < 96) leftmove = false;
            AquaSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, 45, 45);
            return destinationRec;
        }

        public override void xReverse(int distance, bool plus)
        {
            if (plus) xPosition += distance;
            else { xPosition -= distance; }
        }

        public override void yReverse(int distance, bool plus)
        {
            if (plus) yPosition += distance;
            else { yPosition -= distance; }
        }
    }
}