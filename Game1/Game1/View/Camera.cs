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

        int boardSize = 40;
        private int sizeOfTile = 64;
        int heightScale;
        int widthScale;


        public Camera(Viewport graphics)
        {
            int height = graphics.Height;
            int width = graphics.Width;

            if (height < width)
            {
                width = height;
            }
            else
            {
                height = width;
            }

            float scaleY = width - boardSize * 2;
            float scaleX = height - boardSize * 2;

            heightScale = (int)scaleY;
            widthScale = (int)scaleX;
        }

        public Rectangle GetGameWindow()
        {
            return new Rectangle(boardSize, boardSize, heightScale, widthScale);
        }
        public Vector2 returnPositionOfField(int x, int y) //tar emot en x och ett y position
        {
            int visualX = boardSize + x * sizeOfTile;
            int visualY = boardSize + y * sizeOfTile;

            return new Vector2(visualX, visualY);
        }
    }
}
