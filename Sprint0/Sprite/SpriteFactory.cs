using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Controller;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Sprint0.Interfaces;
using Sprint0.Items;
//Author: Gengyi Qin
namespace Sprint0.Sprite
{
    public static class SpriteFactory
    {
        //TO-DO:Initialize all kinds of sprite objects in according methods
        public static LinkMagicalRStandingDownSprite LinkMagicalRStandingDown = new LinkMagicalRStandingDownSprite();
        public static LinkMagicalRStandingLeftSprite LinkMagicalRStandingLeft = new LinkMagicalRStandingLeftSprite();
        public static LinkMagicalRStandingRightSprite LinkMagicalRStandingRight = new LinkMagicalRStandingRightSprite();
        public static LinkMagicalRStandingUpSprite LinkMagicalRStandingUp = new LinkMagicalRStandingUpSprite();
        public static LinkMagicalSStandingDownSprite LinkMagicalSStandingDown = new LinkMagicalSStandingDownSprite();
        public static LinkMagicalSStandingLeftSprite LinkMagicalSStandingLeft = new LinkMagicalSStandingLeftSprite();
        public static LinkMagicalSStandingRightSprite LinkMagicalSStandingRight = new LinkMagicalSStandingRightSprite();
        public static LinkMagicalSStandingUpSprite LinkMagicalSStandingUp = new LinkMagicalSStandingUpSprite();
        public static LinkNoneMovingDownSprite LinkNoneMovingDown = new LinkNoneMovingDownSprite();
        public static LinkNoneMovingLeftSprite LinkNoneMovingLeft = new LinkNoneMovingLeftSprite();
        public static LinkNoneMovingRightSprite LinkNoneMovingRight = new LinkNoneMovingRightSprite();
        public static LinkNoneMovingUpSprite LinkNoneMovingUp = new LinkNoneMovingUpSprite();
        public static LinkNoneStandingDownSprite LinkNoneStandingDown = new LinkNoneStandingDownSprite();
        public static LinkNoneStandingLeftSprite LinkNoneStandingLeft = new LinkNoneStandingLeftSprite();
        public static LinkNoneStandingRightSprite LinkNoneStandingRight = new LinkNoneStandingRightSprite();
        public static LinkNoneStandingUpSprite LinkNoneStandingUp = new LinkNoneStandingUpSprite();
        public static LinkWhiteStandingDownSprite LinkWhiteStandingDown = new LinkWhiteStandingDownSprite();
        public static LinkWhiteStandingLeftSprite LinkWhiteStandingLeft = new LinkWhiteStandingLeftSprite();
        public static LinkWhiteStandingRightSprite LinkWhiteStandingRight = new LinkWhiteStandingRightSprite();
        public static LinkWhiteStandingUpSprite LinkWhiteStandingUp = new LinkWhiteStandingUpSprite();
        public static LinkWoodenStandingDownSprite LinkWoodenStandingDown = new LinkWoodenStandingDownSprite();
        public static LinkWoodenStandingLeftSprite LinkWoodenStandingLeft = new LinkWoodenStandingLeftSprite();
        public static LinkWoodenStandingRightSprite LinkWoodenStandingRight = new LinkWoodenStandingRightSprite();
        public static LinkWoodenStandingUpSprite LinkWoodenStandingUp = new LinkWoodenStandingUpSprite();

        //attack
        public static LinkMagicalRAttackingDownSprite LinkMagicalRAttackingDown = new LinkMagicalRAttackingDownSprite();
        public static LinkMagicalRAttackingLeftSprite LinkMagicalRAttackingLeft = new LinkMagicalRAttackingLeftSprite();
        public static LinkMagicalRAttackingRightSprite LinkMagicalRAttackingRight = new LinkMagicalRAttackingRightSprite();
        public static LinkMagicalRAttackingUpSprite LinkMagicalRAttackingUp = new LinkMagicalRAttackingUpSprite();
        public static LinkMagicalSAttackingDownSprite LinkMagicalSAttackingDown = new LinkMagicalSAttackingDownSprite();
        public static LinkMagicalSAttackingLeftSprite LinkMagicalSAttackingLeft = new LinkMagicalSAttackingLeftSprite();
        public static LinkMagicalSAttackingRightSprite LinkMagicalSAttackingRight = new LinkMagicalSAttackingRightSprite();
        public static LinkMagicalSAttackingUpSprite LinkMagicalSAttackingUp = new LinkMagicalSAttackingUpSprite();
        public static LinkWhiteAttackingDownSprite LinkWhiteAttackingDown = new LinkWhiteAttackingDownSprite();
        public static LinkWhiteAttackingLeftSprite LinkWhiteAttackingLeft = new LinkWhiteAttackingLeftSprite();
        public static LinkWhiteAttackingRightSprite LinkWhiteAttackingRight = new LinkWhiteAttackingRightSprite();
        public static LinkWhiteAttackingUpSprite LinkWhiteAttackingUp = new LinkWhiteAttackingUpSprite();
        public static LinkWoodenAttackingDownSprite LinkWoodenAttackingDown = new LinkWoodenAttackingDownSprite();
        public static LinkWoodenAttackingLeftSprite LinkWoodenAttackingLeft = new LinkWoodenAttackingLeftSprite();
        public static LinkWoodenAttackingRightSprite LinkWoodenAttackingRight = new LinkWoodenAttackingRightSprite();
        public static LinkWoodenAttackingUpSprite LinkWoodenAttackingUp = new LinkWoodenAttackingUpSprite();

        // Enemy Author: Gengyi Qin
        public static EnemyMoblinSprite EnemyMoblin = new EnemyMoblinSprite(0, 0);
        public static EnemyPeahatSprite EnemyPeahat = new EnemyPeahatSprite(0, 0);
        public static EnemyTektiteSprite EnemyTektite = new EnemyTektiteSprite(0, 0);
        public static EnemyKeeseSprite EnemyKeese = new EnemyKeeseSprite(0, 0);
        public static EnemyStalfosSprite EnemyStalfos = new EnemyStalfosSprite(0, 0);
        public static EnemyGoriyaSprite EnemyGoriya = new EnemyGoriyaSprite(0, 0);
        public static EnemyZolSprite EnemyZol = new EnemyZolSprite(0, 0);
        public static EnemyWallmasterSprite EnemyWallmaster = new EnemyWallmasterSprite(0, 0);
        public static EnemyTrapSprite EnemyTrap = new EnemyTrapSprite(0, 0);
        public static EnemyRopeSprite EnemyRope = new EnemyRopeSprite(0, 0);
        public static EnemyAquaSprite EnemyAqua = new EnemyAquaSprite(0, 0);
        public static EnemyDodongoSprite EnemyDodongo = new EnemyDodongoSprite(0, 0);
        public static EnemyOldmanSprite EnemyOldman = new EnemyOldmanSprite(0, 0);
        public static EnemyMerchantSprite EnemyMerchant = new EnemyMerchantSprite(0, 0);

        public static PlayerWoodenSwordSprite PlayerWoodenSword = new PlayerWoodenSwordSprite();

        // Items Author: Zhizhou He, Chuwen Sun
        public static List<ISprite> ItemList = new List<ISprite>();
        public static ItemHeartContainerSprite ItemHeartContainer = new ItemHeartContainerSprite();
        public static ItemGirlSprite ItemGirl = new ItemGirlSprite();
        public static ItemClockSprite ItemClock = new ItemClockSprite();
        public static ItemBombSprite ItemBomb = new ItemBombSprite();
        public static ItemHeartSprite ItemHeart = new ItemHeartSprite();
        public static ItemCompassSprite ItemCompass = new ItemCompassSprite();
        public static ItemMapSprite ItemMap = new ItemMapSprite();
        public static ItemKeySprite ItemKey = new ItemKeySprite();
        public static ItemTriforceSprite ItemTriforce = new ItemTriforceSprite();
        public static ItemWBoomerangSprite ItemWBoomerang = new ItemWBoomerangSprite();
        public static ItemBowSprite ItemBow = new ItemBowSprite();
        public static ItemRuppySprite ItemRuppy = new ItemRuppySprite();
        public static ItemArrowSprite ItemArrow = new ItemArrowSprite();

        // Block Author: Zilin Shao
        public static List<ISprite> BlockList = new List<ISprite>();
        public static ISprite BlockA = new BlockASprite();
        public static ISprite BlockB = new BlockBSprite();
        public static ISprite BlockC = new BlockCSprite();


        //Room Author Zhizhou He
        public static List<ISprite> RoomList = new List<ISprite>();
        public static ISprite RoomBlock = new RoomBlockSprite();
        public static ISprite RoomItem = new RoomItemSprite();
        public static ISprite RoomEnemy = new RoomEnemySprite();
        public static ISprite RoomExterior = new RoomExteriorSprite();

        public static List<ISprite> WallCubeList = new List<ISprite>();
        public static ISprite WallTop = new WallTopSprite();
        public static ISprite WallDown = new WallDownSprite();
        public static ISprite DoorLeft = new DoorLeftSprite();
        public static ISprite DoorRight = new DoorRightSprite();

        //Hud Author: Zilin Shao
        public static List<IHud> HudList = new List<IHud>();
        public static HudHalfHeartSprite HudHalfHeart = new HudHalfHeartSprite();
        public static HudEmptyHeartSprite HudEmptyHeart = new HudEmptyHeartSprite();
        public static ItemHeartContainerSprite HudHeart = new ItemHeartContainerSprite();





        public static void LoadContent(SpriteBatch batch, ContentManager content)
        {
            LoadLinkContent(batch, content);
            LoadItemContent(batch, content);
            LoadEnemyContent(batch, content);
            LoadBlockContent(batch, content);
            LoadRoomContent(batch, content);
            LoadHudContent(batch, content);
            LoadWallCubeContent(batch, content);
        }



        private static void LoadLinkContent(SpriteBatch batch, ContentManager content)
        {
            LinkNoneStandingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneStandingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneStandingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneStandingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneMovingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneMovingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneMovingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneMovingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalRStandingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalRStandingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalRStandingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalRStandingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalSStandingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalSStandingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalSStandingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalSStandingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWhiteStandingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWhiteStandingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWhiteStandingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWhiteStandingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenStandingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenStandingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenStandingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenStandingUp.LoadContent(batch, content.Load<Texture2D>("link"));

            //attack
            LinkMagicalRAttackingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalRAttackingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalRAttackingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalRAttackingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalSAttackingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalSAttackingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalSAttackingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkMagicalSAttackingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWhiteAttackingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWhiteAttackingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWhiteAttackingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWhiteAttackingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenAttackingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenAttackingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenAttackingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenAttackingUp.LoadContent(batch, content.Load<Texture2D>("link"));

        }

        private static void LoadItemContent(SpriteBatch batch, ContentManager content)
        {
            ItemHeartContainer.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemGirl.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemClock.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemBomb.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemHeart.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemCompass.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemKey.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemTriforce.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemWBoomerang.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemBow.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemRuppy.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemArrow.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemMap.LoadContent(batch, content.Load<Texture2D>("item"));

            ItemList.Add(ItemHeartContainer);
            ItemList.Add(ItemGirl);
            ItemList.Add(ItemClock);
            ItemList.Add(ItemBomb);
            ItemList.Add(ItemHeart);
            ItemList.Add(ItemCompass);
            ItemList.Add(ItemKey);
            ItemList.Add(ItemTriforce);
            ItemList.Add(ItemWBoomerang);
            ItemList.Add(ItemBow);
            ItemList.Add(ItemRuppy);
            ItemList.Add(ItemArrow);
            ItemList.Add(ItemMap);

        }

        private static void LoadHudContent(SpriteBatch batch, ContentManager content)
        {
            HudHalfHeart.LoadContent(batch, content.Load<Texture2D>("item"));
            HudEmptyHeart.LoadContent(batch, content.Load<Texture2D>("item"));
            HudHeart.LoadContent(batch, content.Load<Texture2D>("item"));

            ItemList.Add(HudHalfHeart);
            ItemList.Add(HudEmptyHeart);
            ItemList.Add(HudHeart);
        }

        private static void LoadEnemyContent(SpriteBatch batch, ContentManager content)
        {
            EnemyPeahat.LoadContent(batch, content.Load<Texture2D>("enemy"));
            EnemyMoblin.LoadContent(batch, content.Load<Texture2D>("enemy"));
            EnemyTektite.LoadContent(batch, content.Load<Texture2D>("enemy"));
            EnemyKeese.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyStalfos.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyGoriya.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyZol.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyWallmaster.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyTrap.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyRope.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyAqua.LoadContent(batch, content.Load<Texture2D>("boss"));
            EnemyDodongo.LoadContent(batch, content.Load<Texture2D>("boss"));
            EnemyOldman.LoadContent(batch, content.Load<Texture2D>("npc"));
            EnemyMerchant.LoadContent(batch, content.Load<Texture2D>("npc"));
        }

        private static void LoadBlockContent(SpriteBatch batch, ContentManager content)
        {
            BlockA.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            BlockB.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            BlockC.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            BlockList.Add(BlockA);
            BlockList.Add(BlockB);
            BlockList.Add(BlockC);
        }

        private static void LoadRoomContent(SpriteBatch batch, ContentManager content)
        {
            RoomBlock.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            RoomItem.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            RoomEnemy.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            RoomExterior.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            RoomList.Add(RoomBlock);
            RoomList.Add(RoomItem);
            RoomList.Add(RoomEnemy);
            RoomList.Add(RoomExterior);
        }
            private static void LoadWallCubeContent(SpriteBatch batch, ContentManager content)
        {
            WallTop.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            WallDown.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            DoorLeft.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            DoorRight.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            WallCubeList.Add(WallTop);
            WallCubeList.Add(WallDown);
            WallCubeList.Add(DoorLeft);
            WallCubeList.Add(DoorRight);

        }
    }
}
