﻿#region Using statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace TPJ_TankAttack
{
    class Sprite
    {
        private Texture2D image;
        private Vector2 position;
        private Vector2 size;
        private float rotation;
        private Scene scene;

        public Sprite(ContentManager contents, String assetName)
        {
            this.rotation = 0f;
            this.size = new Vector2(1f, 1f);
            this.position = Vector2.Zero;
            this.image = contents.Load<Texture2D>(assetName);
        }

        public void SetScene(Scene s)
        {
            this.scene = s;
        }

        public void Draw(GameTime gameTime)
        {
            Rectangle pos = Camera.WorldSize2PixelRectangle(this.position, this.size);
            scene.SpriteBatch.Draw(this.image, pos, Color.White);
        }

        public void Update(GameTime gameTime) { }
    }
}