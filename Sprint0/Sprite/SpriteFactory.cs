using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Sprint0.Interfaces;

//Author: Gengyi Qin
namespace Sprint0.Sprite
{
    public static class SpriteFactory
    {
        //TO-DO:Initialize all kinds of sprite objects in according methods
        public static LinkNoneMovingDownSprite LinkNoneMovingDown = new LinkNoneMovingDownSprite();
        public static LinkNoneMovingLeftSprite LinkNoneMovingLeft = new LinkNoneMovingLeftSprite();
        public static LinkNoneMovingRightSprite LinkNoneMovingRight = new LinkNoneMovingRightSprite();
        public static LinkNoneMovingUpSprite LinkNoneMovingUp = new LinkNoneMovingUpSprite();
        public static LinkNoneStandingDownSprite LinkNoneStandingDown = new LinkNoneStandingDownSprite();
        public static LinkNoneStandingLeftSprite LinkNoneStandingLeft = new LinkNoneStandingLeftSprite();
        public static LinkNoneStandingRightSprite LinkNoneStandingRight = new LinkNoneStandingRightSprite();
        public static LinkNoneStandingUpSprite LinkNoneStandingUp = new LinkNoneStandingUpSprite();
        public static LinkUsingUpSprite LinkUsingUp = new LinkUsingUpSprite();
        public static LinkUsingLeftSprite LinkUsingLeft = new LinkUsingLeftSprite();
        public static LinkUsingDownSprite LinkUsingDown = new LinkUsingDownSprite();
        public static LinkUsingRightSprite LinkUsingRight = new LinkUsingRightSprite();

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
        public static NPCMerchantSprite NPCMerchant = new NPCMerchantSprite();
        public static NPCFlameSprite NPCFlame = new NPCFlameSprite();

        public static PlayerWoodenSwordSprite PlayerWoodenSwordRight = new PlayerWoodenSwordSprite(SpriteEffects.None, 0);
        public static PlayerWoodenSwordSprite PlayerWoodenSwordLeft = new PlayerWoodenSwordSprite(SpriteEffects.FlipHorizontally, 0);
        public static PlayerWoodenSwordSprite PlayerWoodenSwordUp = new PlayerWoodenSwordSprite(SpriteEffects.None, (float)-1.5708);
        public static PlayerWoodenSwordSprite PlayerWoodenSwordDown = new PlayerWoodenSwordSprite(SpriteEffects.None, (float)1.5708);


        //Zina
        public static PlayerWoodenSwordShootingSprite PlayerWoodenSwordShootingRight = new PlayerWoodenSwordShootingSprite(SpriteEffects.None, 0);
        public static PlayerWoodenSwordShootingSprite PlayerWoodenSwordShootingLeft = new PlayerWoodenSwordShootingSprite(SpriteEffects.FlipHorizontally, 0);
        public static PlayerWoodenSwordShootingSprite PlayerWoodenSwordShootingUp = new PlayerWoodenSwordShootingSprite(SpriteEffects.None, (float)-1.5708);
        public static PlayerWoodenSwordShootingSprite PlayerWoodenSwordShootingDown = new PlayerWoodenSwordShootingSprite(SpriteEffects.None, (float)1.5708);
        public static PlayerWoodenSwordExplodingSprite PlayerWoodenSwordExploding = new PlayerWoodenSwordExplodingSprite(SpriteEffects.None);
        public static PlayerBombSprite PlayerBomb = new PlayerBombSprite(SpriteEffects.None);
        public static PlayerBombExplodingSprite PlayerBombExploding = new PlayerBombExplodingSprite();
        public static PlayerArrowShootingSprite PlayerArrowShootingRight = new PlayerArrowShootingSprite(SpriteEffects.None, 0);
        public static PlayerArrowShootingSprite PlayerArrowShootingLeft = new PlayerArrowShootingSprite(SpriteEffects.FlipHorizontally, 0);
        public static PlayerArrowShootingSprite PlayerArrowShootingUp = new PlayerArrowShootingSprite(SpriteEffects.None, (float)-1.5708);
        public static PlayerArrowShootingSprite PlayerArrowShootingDown = new PlayerArrowShootingSprite(SpriteEffects.None, (float)1.5708);
        public static PlayerArrowExplodingSprite PlayerArrowExploding = new PlayerArrowExplodingSprite(SpriteEffects.None);
        public static PlayerBoomrangShootingSprite PlayerBoomrangShootingRight = new PlayerBoomrangShootingSprite(SpriteEffects.None, 0);
        public static PlayerBoomrangShootingSprite PlayerBoomrangShootingLeft = new PlayerBoomrangShootingSprite(SpriteEffects.FlipHorizontally, 0);
        public static PlayerBoomrangShootingSprite PlayerBoomrangShootingUp = new PlayerBoomrangShootingSprite(SpriteEffects.None, (float)-1.5708);
        public static PlayerBoomrangShootingSprite PlayerBoomrangShootingDown = new PlayerBoomrangShootingSprite(SpriteEffects.None, (float)1.5708);


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
        public static ItemWoodenSwordSprite ItemWoodenSword = new ItemWoodenSwordSprite();

        // Block Author: Zilin Shao
        public static List<ISprite> BlockList = new List<ISprite>();
        public static ISprite BlockA = new BlockASprite();
        public static ISprite BlockB = new BlockBSprite();
        public static ISprite BlockC = new BlockCSprite();
        public static ISprite Lock = new LockSprite();

        //Room Author Zhizhou He
/*        public static List<ISprite> RoomList = new List<ISprite>();
        public static ISprite RoomBlock = new RoomBlockSprite();
        public static ISprite RoomItem = new RoomItemSprite();
        public static ISprite RoomEnemy = new RoomEnemySprite();
        public static ISprite RoomExterior = new RoomExteriorSprite();*/

/*        public static List<ISprite> WallCubeList = new List<ISprite>();
        public static ISprite WallTop = new WallTopSprite();
        public static ISprite WallDown = new WallDownSprite();
        public static ISprite DoorLeft = new DoorLeftSprite();
        public static ISprite DoorRight = new DoorRightSprite();*/

        //Hud Author: Zilin Shao
        public static List<IHud> HudList = new List<IHud>();
        public static HudHalfHeartSprite HudHalfHeart = new HudHalfHeartSprite();
        public static HudEmptyHeartSprite HudEmptyHeart = new HudEmptyHeartSprite();
        public static ItemHeartContainerSprite HudHeart = new ItemHeartContainerSprite();
        public static HudMapPieceSprite HudMapPiece = new HudMapPieceSprite();
        public static HudPointSprite HudPoint = new HudPointSprite();
        public static HudFrameSprite HudFrame = new HudFrameSprite();
        public static HudXSprite HudX = new HudXSprite();
        public static HudOneSprite HudOne = new HudOneSprite();
        public static HudTwoSprite HudTwo = new HudTwoSprite();
        public static HudThreeSprite HudThree = new HudThreeSprite();
        public static HudFourSprite HudFour = new HudFourSprite();
        public static HudFiveSprite HudFive = new HudFiveSprite();
        public static HudSixSprite HudSix = new HudSixSprite();
        public static HudSevenSprite HudSeven = new HudSevenSprite();
        public static HudEightSprite HudEight = new HudEightSprite();
        public static HudNineSprite HudNine = new HudNineSprite();
        public static HudZeroSprite HudZero = new HudZeroSprite();

        //Author: Chuwen Sun
        public static DoorKLeftSprite DoorKLeft = new DoorKLeftSprite();
        public static DoorKRightSprite DoorKRight = new DoorKRightSprite();
        public static DoorKUpSprite DoorKUp = new DoorKUpSprite();
        public static DoorKDownSprite DoorKDown = new DoorKDownSprite();
        /* public static DoorBUpSprite DoorBUp = new DoorBUpSprite();
         public static DoorBDownSprite DoorBDown = new DoorBDownSprite();*/

        public static PickBoxSprite PickBox = new PickBoxSprite();

        public static void LoadContent(SpriteBatch batch, ContentManager content)
        {
            LoadLinkContent(batch, content);
            LoadItemContent(batch, content);
            LoadEnemyContent(batch, content);
            LoadBlockContent(batch, content);
            //LoadRoomContent(batch, content);
            LoadHudContent(batch, content);
            //LoadWallCubeContent(batch, content);
            LoadDoorContent(batch, content);
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

            LinkUsingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkUsingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkUsingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkUsingUp.LoadContent(batch, content.Load<Texture2D>("link"));

            PlayerWoodenSwordRight.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordUp.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordDown.LoadContent(batch, content.Load<Texture2D>("link"));


            PlayerWoodenSwordShootingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordShootingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordShootingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordShootingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordExploding.LoadContent(batch, content.Load<Texture2D>("shoot"));

            //Zina
            PlayerBombExploding.LoadContent(batch, content.Load<Texture2D>("link")); 
            PlayerBomb.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerArrowShootingRight.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerArrowShootingLeft.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerArrowShootingUp.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerArrowShootingDown.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerArrowExploding.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerBoomrangShootingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerBoomrangShootingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerBoomrangShootingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerBoomrangShootingDown.LoadContent(batch, content.Load<Texture2D>("link"));
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
            ItemWoodenSword.LoadContent(batch, content.Load<Texture2D>("item"));

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
            ItemList.Add(ItemWoodenSword);
        }

        private static void LoadHudContent(SpriteBatch batch, ContentManager content)
        {
            HudHalfHeart.LoadContent(batch, content.Load<Texture2D>("item"));
            HudEmptyHeart.LoadContent(batch, content.Load<Texture2D>("item"));
            HudHeart.LoadContent(batch, content.Load<Texture2D>("item"));
            HudMapPiece.LoadContent(batch, content.Load<Texture2D>("Map"));
            HudPoint.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            HudFrame.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudX.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudOne.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudTwo.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudThree.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudFour.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudFive.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudSix.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudSeven.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudEight.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudNine.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudZero.LoadContent(batch, content.Load<Texture2D>("Hud"));
            ItemList.Add(HudHalfHeart);
            ItemList.Add(HudEmptyHeart);
            ItemList.Add(HudHeart);
            PickBox.LoadContent(batch, content.Load<Texture2D>("Hud"));

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
            NPCMerchant.LoadContent(batch, content.Load<Texture2D>("npc"));
            NPCFlame.LoadContent(batch, content.Load<Texture2D>("npc"));
        }

        private static void LoadBlockContent(SpriteBatch batch, ContentManager content)
        {
            BlockA.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            BlockB.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            BlockC.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            Lock.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            BlockList.Add(BlockA);
            BlockList.Add(BlockB);
            BlockList.Add(BlockC);
        }

/*        private static void LoadRoomContent(SpriteBatch batch, ContentManager content)
        {
            RoomBlock.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            RoomItem.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            RoomEnemy.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            RoomExterior.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            RoomList.Add(RoomBlock);
            RoomList.Add(RoomItem);
            RoomList.Add(RoomEnemy);
            RoomList.Add(RoomExterior);
        }*/
/*        private static void LoadWallCubeContent(SpriteBatch batch, ContentManager content)
        {
            WallTop.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            WallDown.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            DoorLeft.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            DoorRight.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            WallCubeList.Add(WallTop);
            WallCubeList.Add(WallDown);
            WallCubeList.Add(DoorLeft);
            WallCubeList.Add(DoorRight);

        }*/

        private static void LoadDoorContent(SpriteBatch batch, ContentManager content)
        {
            DoorKLeft.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            DoorKRight.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            DoorKUp.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            DoorKDown.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            /*            DoorBUp.LoadContent(batch, content.Load<Texture2D>("dungeon"));
                        DoorBDown.LoadContent(batch, content.Load<Texture2D>("dungeon"));*/
        }
    }
}
