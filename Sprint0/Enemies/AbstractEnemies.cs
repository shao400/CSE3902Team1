using Microsoft.Xna.Framework;
using Sprint0.Interfaces;

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
    }
}
