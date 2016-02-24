using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RogueLike.Managers;
using RogueLike.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueLike.Screens
{
    class SplashScreen : GameScreen
    {
        public Image splashScreenImage;

        public float timer = 0;


        public override void LoadContent()
        {
            splashScreenImage = new Image();
            splashScreenImage.Path = "SplashScreenImage";
            splashScreenImage.LoadContent();
            splashScreenImage.Position = new Vector2(ScreenManager.Instance.dimensions.X / 2, ScreenManager.Instance.dimensions.Y / 2);
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if(timer > 5)
            {
                ScreenManager.Instance.ChangeScreen("MainMenuScreen");
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            splashScreenImage.Draw(spriteBatch);
        }

        public void LoadImages()
        {
            
        }

    }
}
