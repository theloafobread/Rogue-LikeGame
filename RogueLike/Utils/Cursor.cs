using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

using RogueLike.Utils;
using RogueLike.Screens;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using RogueLike.Managers;

namespace RogueLike.Utils
{
    class Cursor
    {
        public int cursorAmount = 2;
        public int currentCursor = 0;
        public AnimatedTexture[] cursors;
        public AnimatedTexture cursor;
        public int mouseX;
        public int mouseY;

        static public MouseState mouseState;

        ContentManager content;

        public void LoadContent()
        {
            content = ScreenManager.Instance.Content;
            cursor = new AnimatedTexture(Vector2.Zero,0,.5f,0);
            cursors = new AnimatedTexture[cursorAmount];

            for (int i = 0; i < cursorAmount; i++)
            {
                Console.WriteLine("looped");
                cursors[i] = new AnimatedTexture(Vector2.Zero, 0, 0.5f, 0);
                cursors[i].Load(content, "Cursors/Cursor" + (i + 1).ToString(), 2, 4);
            }

            ChangeCursor(0);

            //cursor.Load(content, "Cursors/Cursor1", 2, 2);
        }

        public void Update(GameTime gameTime)
        {
            mouseState = Mouse.GetState();
            mouseX = mouseState.X;
            mouseY = mouseState.Y;

            cursor.UpdateFrame((float)gameTime.ElapsedGameTime.TotalSeconds);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            cursor.DrawFrame(spriteBatch, new Vector2(mouseX, mouseY));
        }

        public void ChangeCursor(int cursorValue)
        {
            cursor = cursors[cursorValue];
        }
    }
}
