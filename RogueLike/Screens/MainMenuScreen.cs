using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RogueLike.Utils;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using RogueLike.Managers;

namespace RogueLike.Screens
{
    class MainMenuScreen : GameScreen
    {
        public Cursor cursor;
        Image bg;

        public override void LoadContent()
        {
            cursor = new Cursor();
            cursor.LoadContent();
            bg = new Image();
            bg.Path = "MainMenuBG";
            bg.LoadContent();
            bg.Position = new Vector2(ScreenManager.Instance.dimensions.X / 2, ScreenManager.Instance.dimensions.Y / 2);
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            cursor.Update(gameTime);
            base.Update(gameTime);
            KeyboardState keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Enter))
            {
                ScreenManager.Instance.ChangeScreen("PlayScreen");
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            bg.Draw(spriteBatch);
            cursor.Draw(spriteBatch);
        }
    }
}
