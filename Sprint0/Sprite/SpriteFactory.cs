using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Controller;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
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
       

        public static List<ISprite> EnemyList = new List<ISprite>();
        public static EnemyMoblinSprite EnemyMoblin = new EnemyMoblinSprite();
        public static EnemyPeahatSprite EnemyPeahat = new EnemyPeahatSprite();
        public static EnemyTektiteSprite EnemyTektite = new EnemyTektiteSprite();

        // Items Author: Zhizhou He, Chuwen Sun
        public static List<ISprite> ItemList = new List<ISprite>();
        public static ItemHeartSprite ItemHeart = new ItemHeartSprite(); 

        public static void LoadContent(SpriteBatch batch, ContentManager content)
        {
            LoadLinkContent(batch, content);
            LoadItemContent(batch, content);
            LoadEnemyContent(batch, content);
            LoadItemContent(batch, content);
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
            LinkWhiteStandingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWhiteStandingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWhiteStandingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWhiteStandingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenStandingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenStandingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenStandingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkWoodenStandingUp.LoadContent(batch, content.Load<Texture2D>("link"));
        }

        private static void LoadItemContent(SpriteBatch batch, ContentManager content)
        {
            ItemHeart.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemList.Add(ItemHeart);
        }
        
        private static void LoadEnemyContent(SpriteBatch batch, ContentManager content)
        {
            EnemyPeahat.LoadContent(batch, content.Load<Texture2D>("enemy"));
            EnemyMoblin.LoadContent(batch, content.Load<Texture2D>("enemy"));
            EnemyTektite.LoadContent(batch, content.Load<Texture2D>("enemy"));
            EnemyList.Add(EnemyMoblin);
            EnemyList.Add(EnemyPeahat);
            EnemyList.Add(EnemyTektite);
        }

    }
}
