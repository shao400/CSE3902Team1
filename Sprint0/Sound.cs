using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections;


namespace Sprint0
{
    public class Sound : Microsoft.Xna.Framework.Game
    {

        private SoundEffect LinkHurt;
        private SoundEffect SwordSlash;
        //private GraphicsDeviceManager g;
        public Sound(List<SoundEffect> s)
        {
            //g = graphics;
            SwordSlash = s[0];
            LinkHurt = s[1];
            Content.RootDirectory = "Content";
           //SwordSlash = Content.Load<SoundEffect>("Sounds/SwordSlash");

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
