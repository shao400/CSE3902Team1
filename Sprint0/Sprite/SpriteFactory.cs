using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Sprint0.Interfaces;
using Sprint0.UtilityClass;

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
        public static ItemBoomerangSprite ItemBoomerang = new ItemBoomerangSprite();
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

        //Hud Author: Zilin Shao
        public static List<IHud> HudList = new List<IHud>();
        public static HudHalfHeartSprite HudHalfHeart = new HudHalfHeartSprite();
        public static HudEmptyHeartSprite HudEmptyHeart = new HudEmptyHeartSprite();
        public static HudHeartSprite HudHeart = new HudHeartSprite();
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
        public static HudCoverSprite HudCover = new HudCoverSprite();

        //Author: Chuwen Sun
        public static DoorKLeftSprite DoorKLeft = new DoorKLeftSprite();
        public static DoorKRightSprite DoorKRight = new DoorKRightSprite();
        public static DoorKUpSprite DoorKUp = new DoorKUpSprite();
        public static DoorKDownSprite DoorKDown = new DoorKDownSprite();
        public static DoorBUpSprite DoorBUp = new DoorBUpSprite();
        public static DoorBDownSprite DoorBDown = new DoorBDownSprite();

        public static PickBoxSprite PickBox = new PickBoxSprite();

        public static void LoadContent(SpriteBatch batch, ContentManager content)
        {
            LoadLinkContent(batch, content);
            LoadItemContent(batch, content);
            LoadEnemyContent(batch, content);
            LoadBlockContent(batch, content);
            LoadHudContent(batch, content);
            LoadDoorContent(batch, content);
        }



        private static void LoadLinkContent(SpriteBatch batch, ContentManager content)
        {
            LinkNoneStandingDown.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            LinkNoneStandingLeft.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            LinkNoneStandingRight.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            LinkNoneStandingUp.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            LinkNoneMovingDown.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            LinkNoneMovingRight.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            LinkNoneMovingLeft.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            LinkNoneMovingUp.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));

            LinkUsingRight.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            LinkUsingLeft.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            LinkUsingDown.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            LinkUsingUp.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));

            PlayerWoodenSwordRight.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            PlayerWoodenSwordLeft.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            PlayerWoodenSwordUp.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            PlayerWoodenSwordDown.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));


            PlayerWoodenSwordShootingRight.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            PlayerWoodenSwordShootingLeft.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            PlayerWoodenSwordShootingUp.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            PlayerWoodenSwordShootingDown.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            PlayerWoodenSwordExploding.LoadContent(batch, content.Load<Texture2D>(StringHolder.Shoot));

            //Zina
            PlayerBombExploding.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link)); 
            PlayerBomb.LoadContent(batch, content.Load<Texture2D>(StringHolder.Shoot));
            PlayerArrowShootingRight.LoadContent(batch, content.Load<Texture2D>(StringHolder.Shoot));
            PlayerArrowShootingLeft.LoadContent(batch, content.Load<Texture2D>(StringHolder.Shoot));
            PlayerArrowShootingUp.LoadContent(batch, content.Load<Texture2D>(StringHolder.Shoot));
            PlayerArrowShootingDown.LoadContent(batch, content.Load<Texture2D>(StringHolder.Shoot));
            PlayerArrowExploding.LoadContent(batch, content.Load<Texture2D>(StringHolder.Shoot));
            PlayerBoomrangShootingRight.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            PlayerBoomrangShootingLeft.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            PlayerBoomrangShootingUp.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
            PlayerBoomrangShootingDown.LoadContent(batch, content.Load<Texture2D>(StringHolder.Link));
        }

        private static void LoadItemContent(SpriteBatch batch, ContentManager content)
        {
            ItemHeartContainer.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemGirl.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemClock.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemBomb.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemHeart.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemCompass.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemKey.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemTriforce.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemBoomerang.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemBow.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemRuppy.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemArrow.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemMap.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));
            ItemWoodenSword.LoadContent(batch, content.Load<Texture2D>(StringHolder.Item));

            ItemList.Add(ItemHeartContainer);
            ItemList.Add(ItemGirl);
            ItemList.Add(ItemClock);
            ItemList.Add(ItemBomb);
            ItemList.Add(ItemHeart);
            ItemList.Add(ItemCompass);
            ItemList.Add(ItemKey);
            ItemList.Add(ItemTriforce);
            ItemList.Add(ItemBoomerang);
            ItemList.Add(ItemBow);
            ItemList.Add(ItemRuppy);
            ItemList.Add(ItemArrow);
            ItemList.Add(ItemMap);
            ItemList.Add(ItemWoodenSword);
        }

        private static void LoadHudContent(SpriteBatch batch, ContentManager content)
        {
            HudHalfHeart.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudEmptyHeart.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudHeart.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudMapPiece.LoadContent(batch, content.Load<Texture2D>(StringHolder.Map));
            HudPoint.LoadContent(batch, content.Load<Texture2D>(StringHolder.Dungeon));
            HudFrame.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudX.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudOne.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudTwo.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudThree.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudFour.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudFive.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudSix.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudSeven.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudEight.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudNine.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudZero.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            HudCover.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));
            ItemList.Add(HudHalfHeart);
            ItemList.Add(HudEmptyHeart);
            ItemList.Add(HudHeart);
            PickBox.LoadContent(batch, content.Load<Texture2D>(StringHolder.Hud));

        }

        private static void LoadEnemyContent(SpriteBatch batch, ContentManager content)
        {
            EnemyPeahat.LoadContent(batch, content.Load<Texture2D>(StringHolder.Enemy));
            EnemyMoblin.LoadContent(batch, content.Load<Texture2D>(StringHolder.Enemy));
            EnemyTektite.LoadContent(batch, content.Load<Texture2D>(StringHolder.Enemy));
            EnemyKeese.LoadContent(batch, content.Load<Texture2D>(StringHolder.Enemy2));
            EnemyStalfos.LoadContent(batch, content.Load<Texture2D>(StringHolder.Enemy2));
            EnemyGoriya.LoadContent(batch, content.Load<Texture2D>(StringHolder.Enemy2));
            EnemyZol.LoadContent(batch, content.Load<Texture2D>(StringHolder.Enemy2));
            EnemyWallmaster.LoadContent(batch, content.Load<Texture2D>(StringHolder.Enemy2));
            EnemyTrap.LoadContent(batch, content.Load<Texture2D>(StringHolder.Enemy2));
            EnemyRope.LoadContent(batch, content.Load<Texture2D>(StringHolder.Enemy2));
            EnemyAqua.LoadContent(batch, content.Load<Texture2D>(StringHolder.Boss));
            EnemyDodongo.LoadContent(batch, content.Load<Texture2D>(StringHolder.Boss));
            EnemyOldman.LoadContent(batch, content.Load<Texture2D>(StringHolder.NPC));
            NPCMerchant.LoadContent(batch, content.Load<Texture2D>(StringHolder.NPC));
            NPCFlame.LoadContent(batch, content.Load<Texture2D>(StringHolder.NPC));
        }

        private static void LoadBlockContent(SpriteBatch batch, ContentManager content)
        {
            BlockA.LoadContent(batch, content.Load<Texture2D>(StringHolder.Blocks));
            BlockB.LoadContent(batch, content.Load<Texture2D>(StringHolder.Blocks));
            BlockC.LoadContent(batch, content.Load<Texture2D>(StringHolder.Blocks));
            Lock.LoadContent(batch, content.Load<Texture2D>(StringHolder.Blocks));
            BlockList.Add(BlockA);
            BlockList.Add(BlockB);
            BlockList.Add(BlockC);
        }

        private static void LoadDoorContent(SpriteBatch batch, ContentManager content)
        {
            DoorKLeft.LoadContent(batch, content.Load<Texture2D>(StringHolder.Dungeon));
            DoorKRight.LoadContent(batch, content.Load<Texture2D>(StringHolder.Dungeon));
            DoorKUp.LoadContent(batch, content.Load<Texture2D>(StringHolder.Dungeon));
            DoorKDown.LoadContent(batch, content.Load<Texture2D>(StringHolder.Dungeon));
            DoorBUp.LoadContent(batch, content.Load<Texture2D>(StringHolder.Dungeon));
            DoorBDown.LoadContent(batch, content.Load<Texture2D>(StringHolder.Dungeon));
        }
    }
}
