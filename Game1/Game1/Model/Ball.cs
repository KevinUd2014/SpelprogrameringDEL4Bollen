﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1.Model
{
    class Ball
    {
        public Vector2 position;
        private Vector2 velocity = new Vector2(0.01f, 0.01f);
        private float radius = 0.05f;

        public Ball()
        {
            Random r = new Random();// gör så att mönstret slumpas ut
            velocity = (new Vector2((float)r.Next(100) / 100f, (float)r.Next(100) / 100f) * 2f - Vector2.One);// denna uträkning tillhör det!
            velocity.Normalize();///https://msdn.microsoft.com/en-us/library/microsoft.xna.framework.vector2.normalize.aspx // för att mönstret ska fortsätta i sammma linje!
            velocity *= 0.008f; // denna ändrar hastigheten!
            position = new Vector2(0.5f, 0.5f);
        }
        //public Vector2 newPosition
        //{
        //    get
        //    {
        //        return position;
        //    }
        //}
        public Vector2 getVelocity
        {
            get
            {
                return velocity;
            }
        }
        public void setVelocityX()
        {
            velocity.X = -velocity.X;
        }
        public void setVelocityY()
        {
            velocity.Y = -velocity.Y;
        }
        public float getRadius
        {
            get
            {
                return radius;
            }
        }


    }
}
