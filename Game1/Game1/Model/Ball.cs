using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1.Model
{
    class Ball
    {
        public Vector2 position;
        public Vector2 velocity = new Vector2(0.01f, 0.01f);
        public float radius = 0.1f;

        public Ball()
        {
            Random r = new Random();
            velocity = (new Vector2((float)r.Next(100) / 100f, (float)r.Next(100) / 100f) * 2f - Vector2.One);
            velocity.Normalize();
            velocity *= 0.01f;
            position = new Vector2(0.5f, 0.5f);
        }

    }
}
