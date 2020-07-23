using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.Block;
using Sprint0.Interfaces;
using Sprint0.NPCs;
using Sprint0.Player;
using Sprint0.UtilityClass;

namespace Sprint0.Collisions
{
    class LinkNpcCollision
    {
        private Player1 myPlayer;
        private Game1 myGame;
        private INPC merchant = new Merchant(0, 0);

        public LinkNpcCollision(Player1 player, Game1 game)
        {
            myPlayer = player;
            myGame = game;
        }

        public void NpcCollision(List<INPC> npcs)
        {
            Rectangle linkRectangle = myPlayer.GetRectangle();
            Rectangle npcRectangle;
            Rectangle intersectionRectangle;

            foreach (INPC npc in npcs)
            {
                npcRectangle = npc.GetRectangle();             
                intersectionRectangle = Rectangle.Intersect(linkRectangle, npcRectangle);

                if (!intersectionRectangle.IsEmpty)
                {
                    if (npc.GetType() == merchant.GetType())
                    {
                        myGame.currentState = myGame.stateList[8];
                    }
                    // check the collison occuring direction
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height)) // from up or down
                    {
                        if (linkRectangle.Y > npcRectangle.Y) // from down
                        {
                            myPlayer.yAxis += intersectionRectangle.Height;
                        }
                        else //from up
                        {
                            myPlayer.yAxis -= intersectionRectangle.Height;
                        }
                    }
                    else //from right or left
                    {
                        if (linkRectangle.X > npcRectangle.X)//from right
                        {
                            myPlayer.xAxis += intersectionRectangle.Width;
                        }
                        else //from left
                        {
                            myPlayer.xAxis -= intersectionRectangle.Width;
                        }
                    }
                    break;//once link has collision with one block, no need to detect other blocks
                }
                             
            }
            
        }
    }
}
 


