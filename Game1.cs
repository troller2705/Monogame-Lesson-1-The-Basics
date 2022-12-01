using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Lesson_1_The_Basics
{
    public class Game1 : Game
    {
        Texture2D dinoTexture, triceTexture, bushTexture, treeTexture, bgTexture;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            this.Window.Title = "My First Monogame Project";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dinoTexture = Content.Load<Texture2D>("dino");
            triceTexture = Content.Load<Texture2D>("triceratops");
            bushTexture = Content.Load<Texture2D>("bush");
            treeTexture = Content.Load<Texture2D>("palmtree");
            bgTexture = Content.Load<Texture2D>("BG");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Crimson);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            //Background
            _spriteBatch.Draw(bgTexture, new Vector2(0, 0), Color.White);
            //Objects
            _spriteBatch.Draw(dinoTexture, new Vector2(240, 395), Color.White);
            _spriteBatch.Draw(triceTexture, new Vector2(610, 270), Color.White);
            _spriteBatch.Draw(bushTexture, new Vector2(700, 350), Color.White);
            _spriteBatch.Draw(treeTexture, new Vector2(300, 325), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}