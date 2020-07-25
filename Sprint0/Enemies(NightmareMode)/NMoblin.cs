using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;

namespace Sprint0.Enemies
{
    public class NMoblin : AbstractEnemies, IEnemy
    {
        private IPlayer myPlayer;
        private ISprite MoblinSprite;
        private int xPosition, yPosition, xDif, yDif;
        private int frame = 0;
        bool leftmove = false;
        private Rectangle destinationRec, targetRectangle;

        public NMoblin(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            MoblinSprite = new NMoblinSprite();
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                MoblinSprite.Draw(location, leftmove);
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
            MoblinSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, 45, 45);
            return destinationRec;
        }
    }
}