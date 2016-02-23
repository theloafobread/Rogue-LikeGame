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

        public Cursor cursor;

        public override void LoadContent()
        {
            cursor = new Cursor();
            cursor.LoadContent();
            splashScreenImage = new Image();
            splashScreenImage.Path = "SplashScreenImage";
            splashScreenImage.LoadContent();
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            cursor.Update(gameTime);
            base.Update(gameTime);
            timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            //if(timer > 5)
            //{
            //    ScreenManager.Instance.ChangeScreen("MainMenuScreen");
            //}
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            splashScreenImage.Draw(spriteBatch);
            cursor.Draw(spriteBatch);
        }

        public void LoadImages()
        {
            
        }

    }
}
