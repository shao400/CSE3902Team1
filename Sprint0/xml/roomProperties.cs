using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Interfaces;
using Sprint0.Player;

namespace Sprint0.xml
{
    public class roomProperties
    {
        public List<IBlock> blockList;
        public List<IItem> itemList;
        public List<IEnemy> enemyList;
        public Player1 link;

        //Constructor method
        public roomProperties(List<IBlock> b, List<IItem> i, List<IEnemy> e, Player1 p)
        {
            itemList = i;
            enemyList = e;
            blockList = b;
            link = p;
        }
        public void Draw()
        {
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Draw();
            }
            for (int i = 0; i < itemList.Count; i++)
            {
                itemList[i].Draw();
            }
            for (int i = 0; i < blockList.Count; i++)
            {
                blockList[i].Draw();
            }
        }

        public void Update()
        {
            link.Update();
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Update();
            }
            for (int i = 0; i < itemList.Count; i++)
            {
                itemList[i].Update();
            }
            for (int i = 0; i < blockList.Count; i++)
            {
                blockList[i].Update();
            }
        }


    }
}
