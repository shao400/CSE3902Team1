using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Interfaces;
using Sprint0.Player;

namespace Sprint0.xml
{
    class roomProperties
    {
        private List<IBlock> blockList;
        private List<IItem> itemList;
        private List<IEnemy> enemyList;
        private Player1 link;

        //Constructor method
        public roomProperties(List<IBlock> b, List<IItem> i, List<IEnemy> e, Player1 p)
        {
            itemList = i;
            enemyList = e;
            blockList = b;
            link = p;
        }



    }
}
