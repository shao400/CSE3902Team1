﻿using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using Sprint0.Collisions;

namespace Sprint0.Enemies
{
    public class NRope : IEnemy
    {

        private IPlayer myPlayer;
        private ISprite RopeSprite;
        private int xPosition, yPosition, xDif, yDif;
        bool leftmove = false;
        private Rectangle destinationRec, targetRectangle;
        private EnemyAllCollision enemyAllCollision;
        private int health = 2; 
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;
        public NRope(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            RopeSprite = new NRopeSprite();
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
                Born.Draw(new Vector2(destinationRec.X, yPosition), false);
            }

            if (this.GetHealth() > 0 && counter == 34)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                RopeSprite.Draw(location, leftmove);
            }
            if (counter < 70 && this.GetHealth() == 0)
            {
                Death.Draw(new Vector2(destinationRec.X, yPosition), false);
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
                    if (xDif > 0) { xPosition += 3; leftmove = false; }
                    else { xPosition -= 3; leftmove = true; }
                }
                else
                {
                    if (yDif > 0) yPosition += 3;
                    else yPosition -= 3;
                }
                RopeSprite.Update();
            }
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