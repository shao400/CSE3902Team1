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
        public static LinkMagicalRStandingRightSprite LinkMagicalRStandingRightSprite = new LinkMagicalRStandingRightSprite();
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

        public static void LoadContent(SpriteBatch batch, ContentManager content)
        {
            LoadLinkContent(batch, content);
            LoadItemContent(batch, content);
            LoadEnemyContent(batch, content);
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
        }

        private static void LoadItemContent(SpriteBatch batch, ContentManager content)
        {

        }
        
        private static void LoadEnemyContent(SpriteBatch batch, ContentManager content)
        {

        }

    }
}
