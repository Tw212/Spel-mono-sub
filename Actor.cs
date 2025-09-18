using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelmonosub
{
    public class Actor
    {
        protected Texture2D texture;
        protected Vector2 position;
        protected Rectangle rectangle;
        protected Color color;

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, color);
        }
        public virtual void Update()
        {

        }
        public Actor(Texture2D texture, Vector2 position, Point size, Color color)
        {
            this.position = position;
            this.texture = texture;
            this.color = color;
            rectangle = new Rectangle((int)position.X, (int)position.Y, size.X, size.Y);
        }
    }
}