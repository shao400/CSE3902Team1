using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamYoshi.Collisions
{
    public class MarioBlockCollision
    {

        private Mario myMario;

        public MarioBlockCollision(Mario mario)
        {
            myMario = mario;
        }

        public Tuple<int, int, bool, bool> BlockCollisionTest(SoundEffects sound, HUD hud, IList<IBlock> blocks, int x, int y, IList<IItem> items, Camera c)
        {
            Rectangle marioRectangle = myMario.GetRectangle();
            Rectangle blockRectangle;
            Rectangle intersectionRectangle;



            bool hitGround = false; // x
            bool hitCeiling = false; // x

            Tuple<int, int, bool, bool> result;
            foreach (IBlock block in blocks)
            {



                blockRectangle = block.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(marioRectangle, blockRectangle);
                if (!intersectionRectangle.IsEmpty)
                {


                    if ((intersectionRectangle.Width >= intersectionRectangle.Height))
                    {
                        if (marioRectangle.Y > blockRectangle.Y)
                        {
                            block.Hit(items, true, myMario.IsLarge(), hud, sound);
                            hitCeiling = true;
                            y += (intersectionRectangle.Height);
                            marioRectangle.Y += intersectionRectangle.Height;
                        }
                        else
                        {
                            hitGround = true;
                            if (block is Blocks.VerticalWarpPipe)
                            {
                                if (myMario.IsCrouching())
                                {
                                    c.SetXPos(Constants.verticalWarp.Item1 - Constants.tileLength);
                                    x = Constants.verticalWarp.Item1;
                                    y = Constants.verticalWarp.Item2;
                                    break;
                                }
                            }
                            y -= (intersectionRectangle.Height);
                            marioRectangle.Y -= intersectionRectangle.Height;
                        }
                    }
                    else
                    {
                        if (marioRectangle.X > blockRectangle.X)
                        {
                            x += (intersectionRectangle.Width);
                            marioRectangle.X += intersectionRectangle.X;
                        }
                        else
                        {
                            x -= (intersectionRectangle.Width);
                            marioRectangle.X -= intersectionRectangle.X;
                            if (block is Blocks.HorizontalWarpPipe)
                            {
                                c.SetXPos(Constants.horizontalWarp.Item1 - Constants.tileLength);
                                x = Constants.horizontalWarp.Item1;
                                y = Constants.horizontalWarp.Item2;
                                break;
                            }
                        }
                    }
                }
            }
            result = new Tuple<int, int, bool, bool>(x, y, hitCeiling, hitGround);
            return result;
        }

    }
}