using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzleClicker.Core
{
    internal abstract class Component
    {
        internal abstract void Init(ContentManager Content);
        internal abstract void Update(GameTime gameTime);
        internal abstract void Draw(SpriteBatch spriteBatch);
    }
}
