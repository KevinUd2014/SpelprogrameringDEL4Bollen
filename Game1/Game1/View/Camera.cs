using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1.View
{
    class Camera
    {

        private int border;
        private float size;
        int height;
        int width;
        private float scale;


        public Camera(Viewport graphics, int border = 10, float size = 1)
        {
            height = graphics.Height -  border*2; /// har en höjd
            width = graphics.Width - border * 2; ///har en bredd
            this.size = size;
            this.border = border;

            if (height < width)///om höjden är mindre än bredden så sätter vi bredden till höjden!
            {
                width = height;
            }
            else
            {
                height = width;
            }

            //float scaleY = width - boardSize * 2;
            //float scaleX = height - boardSize * 2;

            scale = width / size;

            //heightScale = (int)scaleY;
            //widthScale = (int)scaleX;
        }

        public Rectangle GetGameWindow()
        {
            return new Rectangle((int)border, (int)border, (int)width, (int)height);
        }
        public Vector2 returnPositionOfField(float x, float y) ///tar emot en x och ett y position
        {
            float visualX = border + x * scale;
            float visualY = border + y * scale;

            return new Vector2(visualX, visualY);
        }

        public float scaleSizeTo(float rawsize, float size)
        {
            float normalized = width / rawsize;
            return normalized * size;
        }
    }
}
