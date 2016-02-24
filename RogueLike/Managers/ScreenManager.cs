using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using RogueLike.Screens;

namespace RogueLike.Managers
{
    public class ScreenManager
    {
        public GameScreen currentScreen;
        public GraphicsDevice GraphicsDevice;
        public SpriteBatch SpriteBatch;

        public ContentManager Content{ private set; get; }
        private static ScreenManager instance;

        public TextFileManager tfm = new TextFileManager();

        public Vector2 dimensions = Vector2.Zero;

        public int scale = 1;

        public bool fullscreen; 

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                }

                return instance;
            }
        }

        public ScreenManager()
        {
            currentScreen = new LoadSettingsScreen();
        }

        public void LoadContent(ContentManager Content)
        {
            this.Content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent();
        }

        public void UnloadContent()
        {
            currentScreen.UnloadContent();
        }

        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GraphicsDevice.Clear(Color.Black);
            currentScreen.Draw(spriteBatch);
        }

        public void ChangeScreen(string screenName)
        {
            currentScreen.UnloadContent();
            GameScreen newScreen = (GameScreen)Activator.CreateInstance(Type.GetType("RogueLike.Screens." + screenName));
            newScreen.LoadContent();
            currentScreen = newScreen;
            GraphicsDevice.Clear(Color.Black);
        }
    }
}
