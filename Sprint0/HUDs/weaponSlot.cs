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
            
           if (_link.GetCurrentWeapon().Equals(StringHolder.WoodenSword, System.StringComparison.Ordinal))
            {
                woodenSword.Draw(location, false);
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


    }
}
