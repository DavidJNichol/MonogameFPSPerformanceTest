using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Xml;

namespace MonogamePerformanceTest
{
    public class Sprite
    {
        private int spritePositionX;
        private int spritePositionY;
        private int texturesOriginalWidth;
        private int texturesOriginalHeight;

        private SpriteBatch spriteBatch;
        private Texture2D spriteTexture;

        private Color spriteColor;
        public Sprite(Game game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            //sets sprite position
            spritePositionX = 285;
            spritePositionY = 150;
            //original width is used for resizing sprite in draw call
            texturesOriginalWidth = 1280;
            texturesOriginalHeight = 720;
            spriteColor = Color.White;
        }
        
        public Texture2D GetSpriteTexture()
        {
            return spriteTexture;
        }

        public void SetSpriteTexture(Microsoft.Xna.Framework.Content.ContentManager content)
        {
            spriteTexture = content.Load<Texture2D>("Sprite");
        }

        /*Bad practice to run loops in draw method, but for this
          purpose we want to kill our frames
        */
        public void LoadContent32x32()
        {
            spriteBatch.Begin();
            // Draws 5000 32x32
            for (int i = 0; i < 5000; i++)
            {               
                spriteBatch.Draw(spriteTexture, new Rectangle(spritePositionX, spritePositionY, 32, 32),
                   new Rectangle(0, 0, texturesOriginalWidth, texturesOriginalHeight),
                   spriteColor);                
            }
            spriteBatch.End();
        }
        public void LoadContent64x64()
        {
            spriteBatch.Begin();
            // Draws 5000 64x64
            for (int i = 0; i < 5000; i++)
            {               
                spriteBatch.Draw(spriteTexture, new Rectangle(spritePositionX, spritePositionY, 64, 64),
                   new Rectangle(0, 0, texturesOriginalWidth, texturesOriginalHeight),
                  spriteColor);
            }
            spriteBatch.End();
        }
        public void LoadContent128x128()
        {
            spriteBatch.Begin();
            // Draws 5000 128x128
            for (int i = 0; i < 5000; i++)
            {
                spriteBatch.Draw(spriteTexture, new Rectangle(spritePositionX, spritePositionY, 128, 128),
               new Rectangle(0, 0, texturesOriginalWidth, texturesOriginalHeight),
               spriteColor);
            }
            spriteBatch.End();
        }
        public void LoadContent256x256()
        {
            spriteBatch.Begin();
            // Draws 5000 256x256
            for (int i = 0; i < 5000; i++)
            {
                spriteBatch.Draw(spriteTexture, new Rectangle(spritePositionX, spritePositionY, 256, 256),
               new Rectangle(0, 0, texturesOriginalWidth, texturesOriginalHeight),
                spriteColor);
            }
            spriteBatch.End();
        }
        public void LoadContent512x512()
        {
            spriteBatch.Begin();
            // Draws 5000 512x512
            for (int i = 0; i < 5000; i++)
            {
                spriteBatch.Draw(spriteTexture, new Rectangle(spritePositionX, spritePositionY, 512, 512),
               new Rectangle(0, 0, texturesOriginalWidth, texturesOriginalHeight),
              spriteColor);
            }
            spriteBatch.End();
        }
        public void LoadContent1024x1024()
        {
            spriteBatch.Begin();
            // Draws 5000 1024x1024
            for (int i = 0; i < 5000; i++)
            {
                spriteBatch.Draw(spriteTexture, new Rectangle(spritePositionX, spritePositionY, 1024, 1024),
               new Rectangle(0, 0, texturesOriginalWidth, texturesOriginalHeight),
               spriteColor);
            }
            spriteBatch.End();
        }

        public void SetSpriteTransparency()
        {
            // Sprite transparency == 10%
            spriteColor = new Color(100, 100, 100, 10);
        }

        public void ResetSpriteTransparency()
        {
            // Sprite transparency == 100%
            spriteColor = Color.White;
        }

    }
}
