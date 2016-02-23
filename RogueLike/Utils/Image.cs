using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using RogueLike.Managers;

namespace RogueLike.Utils
{
    public class Image
    {
        public float Alpha;
        public string Text, FontName, Path;
        public Vector2 Position, Scale;
        public Rectangle SourceRect;

        public Texture2D Texture;
        Vector2 origin;
        ContentManager content;
        RenderTarget2D renderTarget;

        Vector2 dimensions;

        public Image()
        {
            Path = string.Empty;
            Text = String.Empty;
            Position = Vector2.Zero;
            Scale = Vector2.One;
            Alpha = 1.0f;
            SourceRect = Rectangle.Empty;
        }

        public void LoadContent()
        {
            content = new ContentManager(
                ScreenManager.Instance.Content.ServiceProvider, "Content");

            if (Path != String.Empty)
            {
                Texture = content.Load<Texture2D>(Path);
                Console.WriteLine("Path is found.");
            }
            else
                Console.WriteLine("No Path found.");

            if (Texture == null)
                Console.WriteLine("Texture was unsuccessfully loadded. Make sure the path is correct.");
            else
                Console.WriteLine("Texture was successfully loaded.");

            if (Texture != null)
            {
                dimensions.X += Texture.Width;
                dimensions.Y += Texture.Height;
            }

            if (SourceRect == Rectangle.Empty)
                SourceRect = new Rectangle(0, 0, (int)(dimensions.X * ScreenManager.Instance.scale), (int)dimensions.Y * ScreenManager.Instance.scale);

            renderTarget = new RenderTarget2D(ScreenManager.Instance.GraphicsDevice, (int)dimensions.X, (int)dimensions.Y);
            ScreenManager.Instance.GraphicsDevice.SetRenderTarget(renderTarget);
            ScreenManager.Instance.GraphicsDevice.Clear(Color.Transparent);
            ScreenManager.Instance.SpriteBatch.Begin();
            if (Texture != null)
                ScreenManager.Instance.SpriteBatch.Draw(Texture, Vector2.Zero, Color.White);
            ScreenManager.Instance.SpriteBatch.End();

            Texture = renderTarget;

            ScreenManager.Instance.GraphicsDevice.SetRenderTarget(null);

        }

        public void UnloadContent()
        {
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            origin = new Vector2(SourceRect.Width / 2, SourceRect.Height / 2);
            spriteBatch.Draw(Texture, SourceRect, Color.White);
            //spriteBatch.Draw(Texture, Position + origin, SourceRect, Color.White * Alpha, 0.0f, origin, Scale, SpriteEffects.None, 0.0f);
        }
    }
}
