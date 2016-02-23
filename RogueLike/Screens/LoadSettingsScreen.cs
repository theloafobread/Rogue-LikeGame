using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using RogueLike.Managers;

namespace RogueLike.Screens
{
    public class LoadSettingsScreen : GameScreen
    {
        public string settingsFileContent;
        public string settingsFilePath;

        public string resolution;
        public string isFullscreen;

        TextFileManager tfm;

        private string[] settings;

        public override void LoadContent()
        {
            tfm = ScreenManager.Instance.tfm;

            base.LoadContent();

            settings = tfm.GetSettings(tfm.GetDataFromFile(@"Settings\BootSettings.txt"));

            LoadAllSettings();
            ApplyAllSettings();

            ScreenManager.Instance.ChangeScreen("SplashScreen");
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
        }

        public void LoadAllSettings()
        {
            resolution = tfm.GetSettingValue(settings, "res");
        }

        public void ApplyAllSettings()
        {
            switch (resolution)
            {
                case "1":
                    ScreenManager.Instance.dimensions = new Vector2(960, 540);
                    Console.WriteLine("Resolution loaded and changed to 960×540.");
                    ScreenManager.Instance.scale = 5;
                    break;
                case "2":
                    ScreenManager.Instance.dimensions = new Vector2(1344, 756);
                    Console.WriteLine("Resolution loaded and changed to 1344×720.");
                    ScreenManager.Instance.scale = 7;
                    break;
                case "3":
                    ScreenManager.Instance.dimensions = new Vector2(1920, 1080);
                    Console.WriteLine("Resolution loaded and changed to 1920×1080.");
                    ScreenManager.Instance.scale = 10;
                    ScreenManager.Instance.fullscreen = true;
                    break;
            }
        }
    }
}
