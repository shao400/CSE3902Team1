using System;
using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System.Collections.Generic;
using Sprint0.Collisions;

namespace Sprint0.Enemies
{   //Zina, Gengyi
    public class NPeahat : AbstractEnemies, IEnemy
    {
        private IPlayer myPlayer;
        private ISprite PeahatSprite;
        private int xPosition, yPosition, xDif, yDif;
        private Rectangle destinationRec, targetRectangle;
        private EnemyAllCollision enemyAllCollision;
        public NPeahat(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            PeahatSprite = new NPeahatSprite();
            destinationRec = new Rectangle(x, y, 45, 45);
            enemyAllCollision = new EnemyAllCollision(this);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                PeahatSprite.Draw(location, false);
            }
        }

        public override void Update()
        {
            targetRectangle = myPlayer.GetRectangle();
            xDif = targetRectangle.X - xPosition;
            yDif = targetRectangle.Y - yPosition;
            if (Math.Abs(xDif) > Math.Abs(yDif))
            {
                if (xDif > 0) xPosition += 3;
                else xPosition -= 3;
            }
            else
            {
                if (yDif > 0) yPosition += 3;
                else yPosition -= 3;
            }
            PeahatSprite.Update();
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

        public override void blockCollisionTest(List<IBlock> blocks) { enemyAllCollision.BlockCollisionTest(blocks); }
    }
}