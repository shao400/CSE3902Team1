using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.Collisions;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{   //Zina
    public class NTektite :  IEnemy
    {

        private IPlayer myPlayer;
        private ISprite TektiteSprite;
        private int  xDif, yDif;
        //private int frame = 0;
        private Rectangle destinationRec, targetRectangle;
        private EnemyAllCollision enemyAllCollision;
        private int health = IntegerHolder.One;
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;
        public NTektite(int x, int y, IPlayer player)
        {
            myPlayer = player;
            TektiteSprite = new NTektiteSprite();
            destinationRec = new Rectangle(x, y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive);
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

        public  void Draw()
        {
            if (counter < IntegerHolder.ThirtyFour)
            {
                Born.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }

            if (this.GetHealth() > 0 && counter == IntegerHolder.ThirtyFour)
            {
                Vector2 location = new Vector2(destinationRec.X, destinationRec.Y);
                TektiteSprite.Draw(location, false);
            }
            if (counter < IntegerHolder.Seventy && this.GetHealth() == 0)
            {
                Death.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }
        }

        public  void Update()
        {
            if (counter < IntegerHolder.ThirtyFour)
            {
                Born.Update();
                counter++;
            }
            else if (counter >= IntegerHolder.ThirtyFour && this.GetHealth() == 0 && counter < IntegerHolder.Seventy)
            {
                Death.Update();
                counter++;
            }
            else
            {
                targetRectangle = myPlayer.GetRectangle();
            xDif = targetRectangle.X - destinationRec.X;
            yDif = targetRectangle.Y - destinationRec.Y;
            if (Math.Abs(xDif) > Math.Abs(yDif))
            {
                if (xDif > 0) destinationRec.X += IntegerHolder.Three;
                else destinationRec.X -= IntegerHolder.Three;
            }
            else
            {
                if (yDif > 0) destinationRec.Y += IntegerHolder.Three;
                else destinationRec.Y -= IntegerHolder.Three;
            }
            TektiteSprite.Update();
            }
        }

        public Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(destinationRec.X, destinationRec.Y, IntegerHolder.ThirtyFive, IntegerHolder.ThirtyFive);
            return destinationRec;
        }

        public void xReverse(int distance, bool plus)
        {
            if (plus) destinationRec.X += distance;
            else { destinationRec.X -= distance; }
        }

        public void yReverse(int distance, bool plus)
        {
            if (plus) destinationRec.Y += distance;
            else { destinationRec.Y -= distance; }
        }
        public void blockCollisionTest(List<IBlock> blocks) { enemyAllCollision.BlockCollisionTest(blocks); }
    }
}
