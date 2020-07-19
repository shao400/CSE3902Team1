using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.Sprite;
using Sprint0.Interfaces;

namespace Sprint0.Enemies
{
    public class Stalfos : AbstractEnemies, IEnemy
    {


        private ISprite StalfosSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;

        public Stalfos(int x, int y)
        {

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
            
        }

        public override Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}