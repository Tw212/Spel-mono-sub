using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Spelmonosub
{
    public class Hamid: Actor
    {
         private float speed = 2;
        public float Speed{
            get{return speed; }
            set{ speed = value;}
        }
        
        public Hamid(Texture2D texture, Vector2 position, Point point, Point size, Color color, float speed): base(texture, position, size, color)
        {
            this.speed = speed;
        }
        public override void Update()
        {
            position.Y += speed;
            position.X += speed;
            rectangle.Y = (int)position.Y;
            rectangle.X = (int)position.X;
        }
    }
}