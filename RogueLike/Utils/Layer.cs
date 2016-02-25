using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace RogueLike.Utils
{
    class Layer
    {
        public class TileMap
        {
            public List<string> row;

            public TileMap()
            {
                row = new List<string>();
            }
        }

        public TileMap tileMap;
        List<Tile> tiles;

        public int[,] mapGrid;

        public Layer()
        {

        }

        public void LoadContent(int gridSize)
        {
            mapGrid = new int[gridSize, gridSize];
        }

        public void UnloadContent()
        {
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
