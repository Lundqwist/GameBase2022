using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameBase2022
{
    public class Game1 : Game
    {
        

        public Game1()
        {
            GameSystems.Initialize(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {

            GameManager.Initialize();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            GameSystems.spriteBatch = new SpriteBatch(GraphicsDevice);
            GameManager.LoadLevel(1);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            EntityManager.Update(gameTime);

            GameManager.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            GameSystems.spriteBatch.Begin();

            EntityManager.Draw(gameTime);
            
            GameSystems.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}