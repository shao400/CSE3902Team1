using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;

namespace Sprint0.Projectile
{
    public abstract class AbstractProjectile : IProjectile
    {
        internal Vector2 position;
        internal int explodeTimer;
        internal IPlayer player;
        internal Rectangle hitBox;
        internal int damage;
        internal string type;

        public bool IsDone { get; set; }
        public int Size { get; set; }
        public int Speed { get; set; }
        public int ShotDistance { get; set; }
        public void SetPosition(int x, int y)
        {
            this.position.X = x;
            this.position.Y = y;
        }
        public string Type()
        {
            return type;
        }
        public virtual int GetDamage()
        {
            int damage = this.damage;
            this.damage = 0;
            return damage;
        }
        public Rectangle GetHitBox()
        {
            return hitBox;
        }

        public Vector2 GetPosition()
        {
            return this.position;
        }

        public abstract void explo(int i);
        public abstract int IsExplode();
        public abstract void Explode();
        public abstract void Shoot();
        public abstract void Stab();
        public abstract void Update();
    }
}
