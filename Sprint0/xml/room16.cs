using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Sprite;

namespace Sprint0.xml
{
    public class room16
    {
        List<IEnemy> enemies = new List<IEnemy>();
        List<IBlock> blocks = new List<IBlock>();
        List<IItem> items = new List<IItem>();
        List<IHud> huds = new List<IHud>();
        List<IDoor> doors = new List<IDoor>();
        List<INPC> NPCs = new List<INPC>();
        Rectangle source = new Rectangle();
        List<int> con = new List<int>();
        

        roomProperties roomX = new roomProperties(16, blocks, items, enemies, huds, source, List<int> con, List<IDoor> d, List<INPC> n)
    }
}
