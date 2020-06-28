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
using Sprint0.WallCube;
using Sprint0.HUD;
using System.Globalization;

// Author: Chuwen Sun
namespace Sprint0.xml
{
    public class Loader
    {
        static public roomProperties LoadFromReader(XmlReader reader, Sound s)
        {
            roomProperties room = null;
            List<IEnemy> enemies = new List<IEnemy>();
            List<IBlock> blocks = new List<IBlock>();
            List<IItem> items = new List<IItem>();
            List<IRoom> rooms = new List<IRoom>();
            List<IHud> huds = new List<IHud>();
            List<IWallCube> cubes = new List<IWallCube>();
            Player1 link = null;
            HealthBar hp = null;
            reader.MoveToContent();
            reader.Read(); // jump over <Room>
            int count = 0;
            CultureInfo cultures = new CultureInfo("en-US");
            while (reader.Read())
            {
                Console.WriteLine("reader.name: " + reader.Name);
                if (reader.Name == "player")
                {
                    count++;
                    link = new Player1(Int32.Parse(reader.GetAttribute("xpos"), cultures), Int32.Parse(reader.GetAttribute("ypos"), cultures), 48, 48, s);
                    Console.WriteLine("link xpos: " + Int32.Parse(reader.GetAttribute("xpos"), cultures) + "link ypos: " + Int32.Parse(reader.GetAttribute("ypos"), cultures));
                }
                else if(reader.Name == "enemy" || reader.Name == "item" || reader.Name == "block" || reader.Name == "interior" || reader.Name == "exterior" || reader.Name == "wallCube" || reader.Name =="hud")
                {
                    count++;
                    Console.WriteLine("2nd loop xpos:" + Int32.Parse(reader.GetAttribute("xpos"), cultures) + "ypos: " + Int32.Parse(reader.GetAttribute("ypos"), cultures) + "type: " + reader.GetAttribute("type"), cultures);
                    int xpos = Int32.Parse(reader.GetAttribute("xpos"), cultures);
                    int ypos = Int32.Parse(reader.GetAttribute("ypos"), cultures);
                    String type = reader.GetAttribute("type");

                    switch (type)
                    {
                        case "HealthBar":
                            huds.Add(new HealthBar(xpos, ypos, link));
                            break;
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
                        case "WallTop":
                            cubes.Add(new WallTop(xpos, ypos));
                            break;
                        case "WallDown":
                            cubes.Add(new WallDown(xpos, ypos));
                            break;
                        case "DoorLeft":
                            cubes.Add(new DoorLeft(xpos, ypos));
                            break;
                        case "DoorRight":
                            cubes.Add(new DoorRight(xpos, ypos));
                            break;
                        case "Heart":
                            items.Add(new Heart(xpos, ypos));
                            break;
                        case "Clock":
                            items.Add(new mClock(xpos, ypos));
                            break;
                    }
                }
            }
            return new roomProperties(blocks, items, enemies, rooms, huds, cubes, link);
        }
    }
}
