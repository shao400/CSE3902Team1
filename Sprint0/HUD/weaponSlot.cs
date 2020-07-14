﻿using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;

namespace Sprint0.HUD
{
    public class WeaponSlot : IHud
    {
        private ItemBowSprite bow = SpriteFactory.ItemBow;
        private ItemWoodenSwordSprite woodenSword = SpriteFactory.ItemWoodenSword;
        private int xAix;
        private int yAix;
        private string weapon;
        Player1 _link;
        //private int width;
        //private int height;
        public WeaponSlot(Game1 myGame)
        { 

            _link = myGame.link;
            weapon = "";
            //width = w;
            //height = h;
        }
        public void Draw(int x, int y)
        {
            //None, WoodenSword, WhiteSword, MagicalSword, MagicalRod
            Vector2 location = new Vector2(x, y);
            //System.Diagnostics.Debug.WriteLine(_link.states.GetCurrentWeapon());
            woodenSword.Draw(location, false);//temp
            if (_link.GetCurrentWeapon().Equals("None", System.StringComparison.Ordinal))
            {
                
            }
            else if (_link.GetCurrentWeapon().Equals("WoodenSword", System.StringComparison.Ordinal))
            {
                woodenSword.Draw(location, false);
            }
            else if (_link.GetCurrentWeapon().Equals("WhiteSword", System.StringComparison.Ordinal))
            {
                
            }else if (_link.GetCurrentWeapon().Equals("MagicalSword", System.StringComparison.Ordinal))
            {
                
            }
            else if (_link.GetCurrentWeapon().Equals("MagicalRod", System.StringComparison.Ordinal))
            {
                
            }

            //linkGetCurrentBow?
            location.X -= 72;
            bow.Draw(location,false);

        }

        public void GetLinkItem()
        {
            //weapon = _link.states.GetCurrentWeapon();        
        }


        public void Update()
        {

        }

        public Rectangle GetRectangle(int x, int y)
        {
            return new Rectangle(x, y, 32, 32);
        }
    }
}
