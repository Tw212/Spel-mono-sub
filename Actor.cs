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

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.Black);
        }
        public virtual void Update()
        {
        }
        public Actor(Texture, position)
    }
}