using System;
using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Collisions;
using System.Collections.Generic;

namespace Sprint0.Enemies
{
    public class NStalfos : IEnemy
    {

        private IPlayer myPlayer;
        private ISprite StalfosSprite;
        private int xPosition, yPosition, xDif, yDif;
        private Rectangle destinationRec, targetRectangle;
        private bool leftmove = false;
        private EnemyAllCollision enemyAllCollision;
        private int health = 1; 
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;
        public NStalfos(int x, int y, IPlayer link)
        {
            myPlayer = link;
            xPosition = x;
            yPosition = y;
            StalfosSprite = new NStalfosSprite();
            destinationRec = new Rectangle(x, y, 45, 45);
            enemyAllCollision = new EnemyAllCollision(this);
            Born = SpriteFactory.EnemyBorn;
            Death = SpriteFactory.EnemyDeath;
        }


        public void Damaged()
        {
            health--;

        }
        public int GetHealth()
        {
            return health;
        }
        public void Draw()
        {
            if (counter < 34)
            {
                Born.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }

            if (this.GetHealth() > 0 && counter == 34)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                StalfosSprite.Draw(location, leftmove);
            }
            if (counter < 70 && this.GetHealth() == 0)
            {
                Death.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }
        }

        public void Update()
        {
            if (counter < 34)
            {
                Born.Update();
                counter++;
            }
            else if (counter >= 34 && this.GetHealth() == 0 && counter < 70)
            {
                Death.Update();
                counter++;
            }
            else
            {
                targetRectangle = myPlayer.GetRectangle();
                xDif = targetRectangle.X - xPosition;
                yDif = targetRectangle.Y - yPosition;
                if (Math.Abs(xDif) > Math.Abs(yDif))
                {
                    if (xDif > 0) { xPosition += 1; leftmove = false; }
                    else { xPosition -= 1; leftmove = true; }
                }
                else
                {
                    if (yDif > 0) yPosition += 1;
                    else yPosition -= 1;
                }
                if (Math.Abs(xDif) > 300 || Math.Abs(yDif) > 300) Flash();
                StalfosSprite.Update();
            }
        }

        private void Flash()
        {
            //A counter maybe needed
            targetRectangle = myPlayer.GetRectangle();
            xPosition = targetRectangle.X;
            yPosition = targetRectangle.Y;
        }

        public Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, 35, 35);
            return destinationRec;
        }

        public void xReverse(int distance, bool plus)
        {
            if (plus) xPosition += distance;
            else { xPosition -= distance; }
        }

        public void yReverse(int distance, bool plus)
        {
            if (plus) yPosition += distance;
            else { yPosition -= distance; }
        }

        public void blockCollisionTest(List<IBlock> blocks) { enemyAllCollision.BlockCollisionTest(blocks); }

    }
}