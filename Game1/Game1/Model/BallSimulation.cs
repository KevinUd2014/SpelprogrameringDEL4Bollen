﻿using Microsoft.Xna.Framework;
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

        public void update() {
            ball.position += ball.getVelocity;
            if(ball.position.X + ball.getRadius > 1 || ball.position.X - ball.getRadius < 0)//från mitten av bollen + radien på bollen så att bollen nuddar kant med kant!
            {
                ball.setVelocityX();
                //ball.velocity.X = -ball.velocity.X;
            }
            if (ball.position.Y + ball.getRadius > 1 || ball.position.Y - ball.getRadius < 0)
            {
                ball.setVelocityY();
                //ball.velocity.Y = -ball.velocity.Y;
            }
        }
        
    }
}
