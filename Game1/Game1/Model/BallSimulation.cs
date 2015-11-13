using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1.Model
{
    class BallSimulation
    {
        public Ball ball;
        public BallSimulation()
        {
            ball = new Ball();
        }
        public void update(GameTime gameTime) {
            ball.position += ball.velocity;
            if(ball.position.X + ball.radius> 1 || ball.position.X - ball.radius < 0)
            {
                ball.velocity.X = -ball.velocity.X;
            }
            if (ball.position.Y > 1 || ball.position.Y < 0)
            {
                ball.velocity.Y = -ball.velocity.Y;
            }
        }
        
    }
}
