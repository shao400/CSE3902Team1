using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public interface ISprite
    {

        void Update();
        void LoadContent(SpriteBatch batch, Texture2D texture);
        void Draw(Vector2 location);
       
    }
}
