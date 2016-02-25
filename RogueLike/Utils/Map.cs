using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueLike.Utils
{
    class Map
    {
        public List<Layer> Layers;

        public Map()
        {

        }

        public void LoadContent()
        {
            foreach (Layer l in Layers)
                l.LoadContent(30);
        }

        public void UnloadContent()
        {
            foreach (Layer l in Layers)
                l.UnloadContent();
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
