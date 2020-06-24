using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Sprint0.Player;
using Sprint0.Enemies;
using Sprint0.Block;
using Sprint0.Items;
using Sprint0.Interfaces;

namespace Sprint0.xml
{
    public class Loader
    {
        static public roomProperties LoadFromReader(XmlReader reader)
        {
            roomProperties room = null;
            List<IEnemy> enemies = new List<IEnemy>();
            List<IBlock> blocks = new List<IBlock>();
            List<IItem> items = new List<IItem>();
            Player1 link = null;
            reader.MoveToContent();
            reader.Read(); // jump over <Room>
            while (reader.Read())
            {
                if (reader.Name == "player")
                {                 
                   link = new Player1(Int32.Parse(reader.GetAttribute("xPos")), Int32.Parse(reader.GetAttribute("yPos")), 48, 48);
                }
                else
                {
                    int xPos = Int32.Parse(reader.GetAttribute("xPos"));
                    int yPos = Int32.Parse(reader.GetAttribute("yPos"));
                    String type = reader.GetAttribute("type");

                    switch (type)
                    {
                        case "Moblin":
                            enemies.Add(new Moblin(xPos, yPos));
                            break;
                        case "Peahat":
                            enemies.Add(new Peahat(xPos, yPos));
                            break;
                        case "Tektite":
                            enemies.Add(new Tektite(xPos, yPos));
                            break;
                        case "BlockA":
                            blocks.Add(new BlockA(xPos, yPos));
                            break;
                        case "BlockB":
                            blocks.Add(new BlockB(xPos, yPos));
                            break;
                        case "BlockC":
                            blocks.Add(new BlockC(xPos, yPos));
                            break;
                    }
                }
            }
            return new roomProperties(blocks, items, enemies, link);
        }
    }
}
