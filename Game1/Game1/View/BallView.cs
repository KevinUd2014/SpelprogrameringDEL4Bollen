using Game1.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1.View
{
    class BallView
    {
        Texture2D box;
        private Camera camera;
        private BallSimulation ballSimulation;
        Texture2D ball;

        public BallView(GraphicsDeviceManager graphics, BallSimulation BallSimulation, ContentManager Content)/// en konstruktor som laddar in först i klassen!
        {   
            ball = Content.Load<Texture2D>("master_ball.png");///laddar in bollen //detta görs bara en gång!

            box = new Texture2D(graphics.GraphicsDevice, 1, 1);///denna skapar en box
            box.SetData<Color>(new Color[] 
            {
                Color.White
            });/// denna sätter vilken färg!

            camera = new Camera(graphics.GraphicsDevice.Viewport);/// skapar en ny camera instans
            ballSimulation = BallSimulation;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
            spriteBatch.Begin();
            spriteBatch.Draw(box, camera.GetGameWindow(), Color.Black);/// ritar ut boxen eller snarare kvadraten!
            spriteBatch.Draw(ball, camera.returnPositionOfField(ballSimulation.ball.position.X, ballSimulation.ball.position.Y), null, Color.White, 0f, new Vector2(ball.Width/2,ball.Height/2), camera.scaleSizeTo(ball.Width, ballSimulation.ball.getRadius * 2f), SpriteEffects.None, 0f);/// denna skalar om bollen så att den passar i min skärm
            spriteBatch.End();
        }
    }
}
