
using System.Collections.Generic;

using Microsoft.Xna.Framework.Audio;




namespace Sprint0
{
    public class Sound
    {

        private SoundEffect LinkHurt;
        private SoundEffect SwordSlash;
        private SoundEffect MagicRod;
        public Sound(List<SoundEffect> s)
        {
            SwordSlash = s[0];
            LinkHurt = s[1];
            MagicRod = s[2];

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
