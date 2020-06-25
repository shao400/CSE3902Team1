using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0.Block;
using Sprint0.Controller;
using Sprint0.Enemies;
using Sprint0.Interfaces;
using Sprint0.Items;
using Sprint0.Player;
using Sprint0.Sprite;
using Sprint0.State;
using System.Collections.Generic;
using System.ComponentModel;
using Sprint0.xml;
using System.Xml;

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
        public roomProperties currentRoom;
        public List<roomProperties> roomList;
        public XmlReader reader;
        public int roomCount;
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
            controllerList.Add(new MouseC(this));
            this.IsMouseVisible = true;
            base.Initialize();
            roomCount = 0;
            roomList = new List<roomProperties>();
            reader = XmlReader.Create("testRoom0.xml");
            roomList.Add(Loader.LoadFromReader(reader));
            reader = XmlReader.Create("testRoom1.xml");
            roomList.Add(Loader.LoadFromReader(reader));
            reader = XmlReader.Create("testRoom2.xml");
            roomList.Add(Loader.LoadFromReader(reader));
            currentRoom = roomList[roomCount];
            reader.Close();
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

            currentRoom.link.Update();
            currentRoom.link.BlockCollisionTest(currentRoom.blockList);
            currentRoom.link.EnemyCollisionTest(currentRoom.enemyList);
            currentRoom.link.ItemCollisionTest(currentRoom.itemList);
            currentRoom.Update();

            base.Update(gameTime);
        }
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            currentRoom.link.getSprite().Draw(new Vector2(currentRoom.link.xAxis, currentRoom.link.yAxis), currentRoom.link.isTakingDmg());
            currentRoom.Draw();
            base.Draw(gameTime);
        }
      
    }
}
