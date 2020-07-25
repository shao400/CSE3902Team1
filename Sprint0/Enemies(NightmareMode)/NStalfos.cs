using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.Player;

namespace Sprint0.Enemies
{
    public class NStalfos : AbstractEnemies, IEnemy
    {


        private ISprite StalfosSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec, targetRectangle;
        private int counter = 0;
        private Player1 _link;
        private int xDif, yDif;
        public NStalfos(int x, int y, Player1 link)
        {
            _link = link;
            xPosition = x;
            yPosition = y;
            StalfosSprite = new EnemyStalfosSprite(x, y);
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                StalfosSprite.Draw(location, false);
            }
        }

        public override void Update()
        {

            targetRectangle = _link.GetRectangle();
            xDif = targetRectangle.X - xPosition;
            yDif = targetRectangle.Y - yPosition;
            if (Math.Abs(xDif) > Math.Abs(yDif))
            {
                if (xDif > 0) xPosition += 2;
                else xPosition -= 2;
            }
            else
            {
                if (yDif > 0) yPosition += 2;
                else yPosition -= 2;
            }

            if (Math.Abs(xDif) > 200 || Math.Abs(yDif) > 200) Flash();


            StalfosSprite.Update();
        }

        private void Flash()
        {
            //A counter needed
            targetRectangle = _link.GetRectangle();
            xPosition = targetRectangle.X;
            yPosition = targetRectangle.Y;
        }

        public override Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}