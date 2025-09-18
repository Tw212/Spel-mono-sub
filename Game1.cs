
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Spelmonosub;

namespace Spel_mono_sub;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Hamid hamid;

    Texture2D pixel;
    

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
        
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        pixel = new Texture2D(GraphicsDevice, 1, 1);
        pixel.SetData([Color.White]);
        gameObjects.Add(new Hamid(pixel, new Vector2(1,1), new Point(),new Point(), new Color(), 3));
    }
    List<Actor> gameObjects = new List<Actor>();
    
    protected override void Update(GameTime gameTime)
    {
        foreach (Actor obj in gameObjects)
        {
            obj.Update();
        }
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        Rectangle rect = new Rectangle
        (10, 10, 10, 10);

        _spriteBatch.Begin();
        foreach (Actor obj in gameObjects)
        {
            obj.Draw(_spriteBatch);
        }
        _spriteBatch.Draw(pixel,rect, Color.AliceBlue);
        _spriteBatch.End();

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
