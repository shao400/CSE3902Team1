
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
        public Sound(List<SoundEffect> s)
        {
            if (s != null)
            {
                SwordSlash = s[0];
                LinkHurt = s[1];
                MagicRod = s[2];
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
        
    }
}
