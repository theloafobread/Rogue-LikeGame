using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RogueLike.Managers;
using RogueLike.Utils;
using Microsoft.Xna.Framework.Content;

namespace RogueLike.Screens
{
    class PlayScreen : GameScreen
    {
        public Map map1;

        ContentManager content;

        public Cursor cursor;

        Texture2D test;

        TextFileManager tfm;

        public int mapSize;

        public override void LoadContent()
        {
            tfm = ScreenManager.Instance.tfm;

            content = ScreenManager.Instance.Content;
            cursor = new Cursor();
            cursor.LoadContent();

            string data = tfm.GetDataFromFile("Load/Maps/Map1.txt");
            string[] values = tfm.GetSettingSection(data);

            int column = 0;
            int row = 0;

            foreach (string str in values)
            {
                string[] value = tfm.GetSettings(str);
                map1.Layers[0].mapGrid[column, row] = Int32.Parse(tfm.GetSettingValue(value, column.ToString()));
                column++;
                if(column == 9)
                {
                    column = 0;
                    row++;
                }
            }

            //test = content.Load<Texture2D>("TileMaps/Tileset1");
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            cursor.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            cursor.Draw(spriteBatch);
            //spriteBatch.Draw(test, new Rectangle(0,0,(int)ScreenManager.Instance.dimensions.X, (int)ScreenManager.Instance.dimensions.Y), Color.White);
        }
    }
}
