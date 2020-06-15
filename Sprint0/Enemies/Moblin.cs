using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0.Enemies
{
    public class Moblin : IEnemy
    {
      

        private static ISprite PiranhaSprite = new Sprites.GreenPlantSprite();
        private int xPosition;
        private int yPosition;
        private int width;
        private int height;

        public Moblin(int x, int y, int height_e, int width_e)
        {
            
            xPosition = x;
            yPosition = y;
            width = width_e;
            height = height_e;
        }



        public void Draw()
        {
            
        }

        public void Reverse(int w)
        {
        }

        public void Update(IList<IBlock> blocks, IList<IEnemy> enemies)
        {
            EnemyMoblinSprite.update();
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(xPosition, yPosition, width, height);
        }
    }
}