using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0.Controller;
using Sprint0.Player;
using System.Collections.Generic;

namespace Sprint0
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    /// Name: Zilin Shao
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Texture2D luigi;
        public SpriteFont font;
        public IController controls;
        public ISprite sprite;
        public Player1 player1;

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
            base.Initialize();
            player1 = new Player1(100, 100, 50, 80);
            sprite = player1.getSprite();
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
            //luigi = Content.Load<Texture2D>("luigi");
            //spriteX = 400;
            //spriteY = 240;
            
            //font = Content.Load<SpriteFont>("Credits1");
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
            
            sprite = player1.getSprite();
            sprite.Update();
            player1.Stand();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            sprite.Draw(new Vector2(player1.xAxis, player1.yAxis));
            // TODO: Add your drawing code here
            //spriteBatch.Begin();
            //spriteBatch.Draw(luigi, new Rectangle(spriteX,spriteY,80,48), Color.White);
            //spriteBatch.End();
            //Vector2 location = new Vector2();
            //location.X = spriteX;
            //location.Y = spriteY;
            //sprite.Draw(spriteBatch,location);

            //spriteBatch.Begin();
            //spriteBatch.DrawString(font, "Credits\nProgram made by: Zilin Shao" +
            //    "\nUrl:www.mariomayhem.com/downloads/sprites/super_mario_bros_sprites.php ",
            //    new Vector2(500, 200), Color.Black);
            //spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
