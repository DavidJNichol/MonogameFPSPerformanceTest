using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonogamePerformanceTest
{
   public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont font;
        FPSComponent fps;
        Sprite sprite;
        InputHandler inputHandler;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            fps = new FPSComponent(this, true, true);
            sprite = new Sprite(this);
            inputHandler = new InputHandler(this, Content);
            this.Components.Add(fps);           
        }

        protected override void Initialize()
        {
            //VSync off
            graphics.SynchronizeWithVerticalRetrace = false;
            IsFixedTimeStep = false;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            sprite.SetSpriteTexture(Content);
            //set font
            font = Content.Load<SpriteFont>("Arial");
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //screen text instructions
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "Hold Q for 32x32, W for 64x64, E for 128x128, R for 256x256, " +
                "T for 512x512, Y for 1024x1024", new Vector2(40,0), Color.White);
            spriteBatch.DrawString(font, "Press U to toggle 10% transparency", new Vector2(260, 20), Color.White);
            spriteBatch.DrawString(font, "See window title for FPS", new Vector2(290, 40), Color.White);
            spriteBatch.End();

            //Check for input
            inputHandler.CheckInput();
            
            base.Draw(gameTime);
        }
    }
}