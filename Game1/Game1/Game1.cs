using Game1.View;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D box;

        Texture2D ball;
        

        Camera camera;

        public Game1()
        {

            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.ApplyChanges();
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

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            

            spriteBatch = new SpriteBatch(GraphicsDevice);
            ball = Content.Load<Texture2D>("pokeball.png");

            // TODO: use this.Content to load your game content here
            camera = new Camera(GraphicsDevice.Viewport);
            box = new Texture2D(GraphicsDevice, 1, 1);
            box.SetData<Color>(new Color[] { Color.White });
            
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

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //BallView.Draw(spriteBatch, Content);
            spriteBatch.Begin();
            spriteBatch.Draw(box, camera.GetGameWindow(), Color.Black);// ritar ut boxen eller snarare kvadraten!
            spriteBatch.Draw(ball, camera.returnPositionOfField(0, 0), null, Color.White, 0f, Vector2.Zero, 0.12f, SpriteEffects.None, 0f);// denna skalar om bollen så att den passar i min skärm
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
