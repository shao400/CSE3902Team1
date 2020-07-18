
using System.Collections.Generic;

using Microsoft.Xna.Framework.Audio;



//Author: Lufei Ouyang
namespace Sprint0
{
    public class Sound
    {

        private SoundEffect LinkHurt;
        private SoundEffect SwordSlash;
        private SoundEffect MagicRod;
        private SoundEffect ArrowAndBoomerang;
        private SoundEffect BombBlow;
        private SoundEffect BombDrop;
        private SoundEffect EnemyDie;
        private SoundEffect EnemyHit;
        private SoundEffect GetHeart;
        private SoundEffect LinkDie;
        private SoundEffect LowHealth;
        private SoundEffect SwordShoot;
        private SoundEffect GetItem;
        private SoundEffect DoorUnlock;
        private SoundEffect GetRupee;
        public Sound(List<SoundEffect> s)
        {
            if (s != null)
            {
                SwordSlash = s[0];
                LinkHurt = s[1];
                MagicRod = s[2];
                ArrowAndBoomerang = s[3];
                BombBlow = s[4];
                BombDrop = s[5];
                EnemyDie = s[6];
                EnemyHit = s[7];
                GetHeart = s[8];
                LinkDie = s[9];
                LowHealth = s[10];
                SwordShoot = s[11];
                GetItem = s[12];
                DoorUnlock = s[13];
                GetRupee = s[14];

            }
            

        }
        public void swordSlash()
        {
            SwordSlash.Play();
        }
        public void linkHurt()
        {
            LinkHurt.Play();
        }
        public void magicRod()
        {
            MagicRod.Play();
        }
        public void arrowAndBoomerang()
        {
            ArrowAndBoomerang.Play();
        }
        public void bombBlow()
        {
            BombBlow.Play();
        }
        public void bombDrop()
        {
            BombDrop.Play();
        }
        public void enemyDie()
        {
            EnemyDie.Play();
        }
        public void enemyHit()
        {
            EnemyHit.Play();
        }
        public void getHeart()
        {
            GetHeart.Play();
        }
        public void linkDie()
        {
            LinkDie.Play();
        }
        public void lowHealth()
        {
            LowHealth.Play();
        }
        public void swordShoot()
        {
            SwordShoot.Play();
        }
        public void getItem()
        {
            GetItem.Play();
        }
        public void doorUnlock()
        {
            DoorUnlock.Play();
        }
        public void getRupee()
        {
            GetRupee.Play();
        }


    }
}
