using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using Sprint0.UtilityClass;

namespace Sprint0.HUDs
{
    public class WeaponSlot : IHud
    {
        private ItemWoodenSwordSprite woodenSword = SpriteFactory.ItemWoodenSword;
        private IItem equipedItem;
        private ISprite equipedItemSprite;
        Player1 _link;
        public WeaponSlot(Game1 myGame)
        { 
            _link = myGame.link;            
        }
        public void Draw(int x, int y)
        {
            Vector2 location = new Vector2(x, y);
            
            if (_link.GetCurrentWeapon().Equals(StringHolder.None, System.StringComparison.Ordinal))
            {
                
            }
            else if (_link.GetCurrentWeapon().Equals(StringHolder.WoodenSword, System.StringComparison.Ordinal))
            {
                woodenSword.Draw(location, false);
            }
            else if (_link.GetCurrentWeapon().Equals(StringHolder.WhiteSword, System.StringComparison.Ordinal))
            {
                
            }else if (_link.GetCurrentWeapon().Equals(StringHolder.MagicalSword, System.StringComparison.Ordinal))
            {
                
            }
            else if (_link.GetCurrentWeapon().Equals(StringHolder.MagicalRod, System.StringComparison.Ordinal))
            {
                
            }

            location.X -= 72;
            if(_link.myInventory.currentItem != 0)
            {
                int itemNum = _link.myInventory.moveCountTot;
                equipedItem = _link.myInventory.myItemList[itemNum];
                equipedItemSprite = _link.myInventory.getItemSprite(equipedItem);
                equipedItemSprite.Draw(location, false);
            }
            

    }

        public static void GetLinkItem()
        {
                    
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
