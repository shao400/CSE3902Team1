using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using System.Collections.Generic;

namespace Sprint0.Enemies
{
    public abstract class AbstractEnemies : IEnemy
    {
        internal int health = 1;
        public void Damaged()
        {
            health--;
            
        }
        public int GetHealth()
        {
            return health;
        }
        public abstract void Draw();
        public abstract Rectangle GetRectangle();
        public abstract void Update();
        public abstract void xReverse(int distance, bool plus);
        public abstract void yReverse(int distance, bool plus);

        public abstract void blockCollisionTest(List<IBlock> blocks);
    }
}
