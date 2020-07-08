using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;

namespace Sprint0.Projectile
{
    public abstract class AbstractProjectile : IProjectile
    {
        internal bool shooting;
        internal bool exploding;
        internal ISprite sprite;
        internal IEnemy enemy;
        internal Vector2 position;
        internal int explodeTimer;
        internal IPlayer player;
        internal Rectangle hitBox;
        internal int damage;

        public bool IsDone { get; set; }
        public int Size { get; set; }
        public int Speed { get; set; }
        public int ShotDistance { get; set; }
        public void SetPosition(int x, int y)
        {
            this.position.X = x;
            this.position.Y = y;
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
        public void Stop()
        {

        }


        public abstract void Explode();
        public abstract void Shoot();
        public abstract void Stab();
        public abstract void Update();
    }
}
