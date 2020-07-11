using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;

namespace Sprint0.HUD
{
    public class ItemSlot : IHud
    {
        private static SpriteFont _font;
        private static SpriteBatch _batch;
        private int xAix;
        private int yAix;

        Player1 _link;
        //private int width;
        //private int height;
        public ItemSlot(int x, int y, Player1 link, SpriteBatch batch, SpriteFont font)
        { 
            xAix = x;
            yAix = y;
            _font = font;
            _batch = batch;
            //width = w;
            //height = h;
        }
        public void Draw()
        {
            Vector2 location = new Vector2(xAix, yAix);
            _batch.Begin();
            _batch.DrawString(_font, "0", location, Color.Black);
            _batch.End();
        }




        public void Update()
        {

        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(xAix, yAix, 32, 32);
        }
    }
}
