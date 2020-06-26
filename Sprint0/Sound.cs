
using System.Collections.Generic;

using Microsoft.Xna.Framework.Audio;



namespace Sprint0
{
    public class Sound
    {

        private SoundEffect LinkHurt;
        private SoundEffect SwordSlash;
        public Sound(List<SoundEffect> s)
        {
            SwordSlash = s[0];
            LinkHurt = s[1];

        }
        public void swordSlash()
        {
            SwordSlash.Play();
        }
        public void linkHurt()
        {
            LinkHurt.Play();
        }
    }
}
