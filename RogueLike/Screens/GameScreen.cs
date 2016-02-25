using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using RogueLike.Managers;

namespace RogueLike.Screens
{
    public class GameScreen
    {
        public Type type;


        public GameScreen()
        {
            type = this.GetType();
        }

        public virtual void LoadContent()
        {
        }
        public virtual void UnloadContent()
        {
            ScreenManager.Instance.Content.Unload();
        }

        public virtual void Update(GameTime gameTime)
        {
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
