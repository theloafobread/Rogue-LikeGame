using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RogueLike.Libs.Tiled;
using RogueLike.Managers;
using RogueLike.Utils;
using Microsoft.Xna.Framework.Content;

namespace RogueLike.Screens
{
    class PlayScreen : GameScreen
    {
        Map map;

        ContentManager content;

        public Cursor cursor;

        Texture2D test;

        public override void LoadContent()
        {
            content = ScreenManager.Instance.Content;
            map = new Map();
            map = Map.Load("Content/TMXMaps/Test1.tmx", content);
            cursor = new Cursor();
            cursor.LoadContent();

            test = content.Load<Texture2D>("TileMaps/Tileset1");
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            //map.Layers["Collision"].Opacity = 0;
            //map.Layers["Visual"].Opacity = 1;
            cursor.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch, new Rectangle(0, 0, (int)ScreenManager.Instance.dimensions.X, (int)ScreenManager.Instance.dimensions.Y), new Vector2(0,0));
            cursor.Draw(spriteBatch);
            //spriteBatch.Draw(test, new Rectangle(0,0,(int)ScreenManager.Instance.dimensions.X, (int)ScreenManager.Instance.dimensions.Y), Color.White);
        }
    }
}
