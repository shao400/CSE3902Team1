
using System.Collections.Generic;

using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using Sprint0.GameStates;
using Sprint0.Items;



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
        private SoundEffect BossScream1;
        private SoundEffect BossScream2;
        private SoundEffect BossScream3;
        private SoundEffect Fanfare;
        private SoundEffect KeyAppear;
        private SoundEffect Recorder1;
        private SoundEffect RefillLoop;
        private SoundEffect Secret;
        private SoundEffect Shield;
        private SoundEffect Shore;
        private SoundEffect Stairs;
        private SoundEffect SwordCombine;
        private SoundEffect Text;
        private SoundEffect TextShow;
        private SoundEffect GetTriforce;
        private SoundEffect Candle;
        private Song Intro;
        private Song Labyrinth;
        public Sound(List<SoundEffect> s, List<Song> song)
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
                BossScream1 = s[15];
                BossScream2 = s[16];
                BossScream3 = s[17];
                Fanfare = s[18];
                KeyAppear = s[19];
                Recorder1 = s[20];
                RefillLoop = s[21];
                Secret = s[22];
                Shield = s[23];
                Shore = s[24];
                Stairs = s[25];
                SwordCombine = s[26];
                Text = s[27];
                TextShow = s[28];
                GetTriforce = s[29];
                Candle = s[30];

                Intro = song[0];
                Labyrinth = song[1];

            }
            

        }
        public void pause()
        {
            MediaPlayer.Pause();

        }
        public void intro()
        {
            MediaPlayer.Play(Intro);
            MediaPlayer.IsRepeating = true;
        }
        public void labyrinth()
        {
            MediaPlayer.Play(Labyrinth);
            MediaPlayer.IsRepeating = true;
        }
        public void candle()
        {
            Candle.Play();
        }
        public void getTriforce()
        {
            GetTriforce.Play();
        }
        public void textShow()
        {
            TextShow.Play();
        }
        public void text()
        {
            Text.Play();
        }
        public void swordCombine()
        {
            SwordCombine.Play();
        }
        public void stairs()
        {
            Stairs.Play();
        }
        public void shore()
        {
            Shore.Play();
        }
        public void shield()
        {
            Shield.Play();
        }
        public void secret()
        {
            Secret.Play();
        }
        public void refillLoop()
        {
            RefillLoop.Play();
        }
        public void recorder1()
        {
            Recorder1.Play();
        }
        public void keyAppear()
        {
            KeyAppear.Play();
        }
        public void fanfare()
        {
            Fanfare.Play();
        }
        public void bossScream1()
        {
            BossScream1.Play();
        }
        public void bossScream2()
        {
            BossScream2.Play();
        }
        public void bossScream3()
        {
            BossScream3.Play();
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
