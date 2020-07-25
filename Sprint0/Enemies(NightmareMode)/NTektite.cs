using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{   //Zina
    public class NTektite : AbstractEnemies, IEnemy
    {

        private IPlayer myPlayer;
        private ISprite TektiteSprite;
        private int xPosition, yPosition, xDif, yDif;
        private int frame = 0;
        private Rectangle destinationRec, targetRectangle;

        public NTektite(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            TektiteSprite = new NTektiteSprite();
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                TektiteSprite.Draw(location, false);
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
            TektiteSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, 45, 45);
            return destinationRec;
        }
    }
}
