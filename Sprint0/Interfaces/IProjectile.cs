using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Interfaces
{
    public interface IProjectile
    {
        void Shoot();
        void Explode();
        void Stab();
        void explo(int i);
        int IsExplode();
        Rectangle GetHitBox();
        int Speed { get; set; }
        int ShotDistance { get; set; }
        bool IsDone { get; set; }
        void Update();
    }
}
