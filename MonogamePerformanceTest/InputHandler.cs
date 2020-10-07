using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MonogamePerformanceTest
{
    class InputHandler
    {
        Sprite sprite;
        public InputHandler(Game game, Microsoft.Xna.Framework.Content.ContentManager content) 
        {
            sprite = new Sprite(game);
            // sets the sprite texture using Content from game1
            sprite.SetSpriteTexture(content);
        }

        public void CheckInput()
        {           
            //Loads sprites
            if(Keyboard.GetState().IsKeyDown(Keys.Q))
            {
                sprite.LoadContent32x32();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                sprite.LoadContent64x64();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.E))
            {
                sprite.LoadContent128x128();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.R))
            {
                sprite.LoadContent256x256();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.T))
            {
                sprite.LoadContent512x512();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Y))
            {
                sprite.LoadContent1024x1024();
            }
            // Sets sprite transparency to 10%
            if(Keyboard.GetState().IsKeyDown(Keys.U))
            {
                sprite.SetSpriteTransparency();
            }
            // Sets sprite transparency to 100%
            if (Keyboard.GetState().IsKeyUp(Keys.U))
            {
                sprite.ResetSpriteTransparency();
            }

        }
    }
}
