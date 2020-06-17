using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0.Block;
using Sprint0.Controller;
using Sprint0.Enemies;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using Sprint0.State;
using System.Collections.Generic;
using System.ComponentModel;

namespace Sprint0
{
    /// <summary>
    /// This is the main type for your game.
    /// 

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public SpriteFont font;
        public IController controls;
        public ISprite sprite;
        public Player1 player1;
        public ISprite enemy;
        public ISprite item;
        public ISprite block;
        public int enemyCount;
        public int itemCount;
        public int blockCount;

        public IBlock blockA;
        public IBlock blockB;
        public IBlock blockC;
        public List<IBlock> BlockList;

        public IEnemy moblin;
        public List<IEnemy> EnemyList;

        List<object> controllerList; // could also be defined as List <IController>
    
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            controllerList = new List<object>();
            controllerList.Add(new KeyboardC(this));
            controllerList.Add(new ItemsController(this));
            base.Initialize();
            player1 = new Player1(100, 100, 48, 48);
            sprite = player1.getSprite();
            enemyCount = 0;
            itemCount = 0;
            blockCount = 0;
            enemy = SpriteFactory.EnemyList[enemyCount];
            item = SpriteFactory.ItemList[itemCount];
            block = SpriteFactory.BlockList[blockCount];

            blockA = new BlockA(400, 350);
            blockB = new BlockB(250, 350);
            blockC = new BlockC(100, 350);

            BlockList = new List<IBlock>();
            BlockList.Add(blockA);
            BlockList.Add(blockB);
            BlockList.Add(blockC);

            moblin = new Moblin(650, 240);            
            EnemyList = new List<IEnemy>();
            EnemyList.Add(moblin);
        }
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            // TODO: use this.Content to load your game content here

            Sprite.SpriteFactory.LoadContent(spriteBatch, Content);
            
        }
        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

            // TODO: Add your update logic here
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }

            player1.Update();

            player1.BlockCollisionTest(BlockList);
            player1.EnemyCollisionTest(EnemyList);
            
            
            item.Update();
            block.Update();

            moblin.Update();

            base.Update(gameTime);
        }
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            player1.getSprite().Draw(new Vector2(player1.xAxis, player1.yAxis), player1.isTakingDmg());        
            moblin.Draw();
            item.Draw(new Vector2(400, 150), false);

            blockA.Draw();
            blockB.Draw();
            blockC.Draw();
            base.Draw(gameTime);
        }
      
    }
}
