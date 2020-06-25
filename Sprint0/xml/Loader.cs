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
using Sprint0.Rooms;

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
            List<IRoom> rooms = new List<IRoom>();
            Player1 link = null;
            reader.MoveToContent();
            reader.Read(); // jump over <Room>
            int count = 0;
            while (reader.Read())
            {
                Console.WriteLine("reader.name: " + reader.Name);
                if (reader.Name == "player")
                {
                    count++;
                    link = new Player1(Int32.Parse(reader.GetAttribute("xpos")), Int32.Parse(reader.GetAttribute("ypos")), 48, 48);
                    Console.WriteLine("link xpos: " + Int32.Parse(reader.GetAttribute("xpos")) + "link ypos: " + Int32.Parse(reader.GetAttribute("ypos")));
                }
                else if(reader.Name == "enemy" || reader.Name == "item" || reader.Name == "block" || reader.Name == "interior" || reader.Name == "exterior")
                {
                    count++;
                    Console.WriteLine("2nd loop xpos:" + Int32.Parse(reader.GetAttribute("xpos")) + "ypos: " + Int32.Parse(reader.GetAttribute("ypos")) + "type: " + reader.GetAttribute("type"));
                    int xpos = Int32.Parse(reader.GetAttribute("xpos"));
                    int ypos = Int32.Parse(reader.GetAttribute("ypos"));
                    String type = reader.GetAttribute("type");

                    switch (type)
                    {
                        case "Moblin":
                            enemies.Add(new Moblin(xpos, ypos));
                            break;
                        case "Peahat":
                            enemies.Add(new Peahat(xpos, ypos));
                            break;
                        case "Tektite":
                            enemies.Add(new Tektite(xpos, ypos));
                            break;
                        case "BlockA":
                            blocks.Add(new BlockA(xpos, ypos));
                            break;
                        case "BlockB":
                            blocks.Add(new BlockB(xpos, ypos));
                            break;
                        case "BlockC":
                            blocks.Add(new BlockC(xpos, ypos));
                            break;
                        case "RoomBlock":
                            rooms.Add(new RoomBlock(xpos, ypos));
                            break;
                        case "RoomEnemy":
                            rooms.Add(new RoomEnemy(xpos, ypos));
                            break;
                        case "RoomItem":
                            rooms.Add(new RoomItem(xpos, ypos));
                            break;
                        case "exRoom":
                            rooms.Add(new ExRoom(xpos, ypos));
                            break;
                    }
                }
            }
            return new roomProperties(blocks, items, enemies, rooms, link);
        }
    }
}
