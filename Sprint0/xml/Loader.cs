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
using Microsoft.Xna.Framework;

// Author: Chuwen Sun
namespace Sprint0.xml
{
    public static class Loader
    {
        static public roomProperties LoadFromReader(XmlReader reader, Sound s)
        {
            int roomID = -1;
            List<IEnemy> enemies = new List<IEnemy>();
            List<IBlock> blocks = new List<IBlock>();
            List<IItem> items = new List<IItem>();
            List<IRoom> rooms = new List<IRoom>();
            List<IHud> huds = new List<IHud>();
            List<IWallCube> cubes = new List<IWallCube>();
            Player1 link = null;
            reader.MoveToContent();
            reader.Read(); // jump over <Room>
            CultureInfo cultures = new CultureInfo("en-US");
            Rectangle source = new Rectangle(0,0,0,0);
            List<int> Con = new List<int>();
            while (reader.Read())
            {
                if (reader.Name == "player")
                {
                    link = new Player1(Int32.Parse(reader.GetAttribute("xpos"), cultures), Int32.Parse(reader.GetAttribute("ypos"), cultures), 48, 48, s);
                }
                else if (reader.Name == "src")
                {
                    source = new Rectangle(Int32.Parse(reader.GetAttribute("xpos"), cultures), Int32.Parse(reader.GetAttribute("ypos"), cultures), 256, 176);
                }else if (reader.Name == "connect")
                {
                    Con.Add(Int32.Parse(reader.GetAttribute("up"), cultures));
                    Con.Add(Int32.Parse(reader.GetAttribute("down"), cultures));
                    Con.Add(Int32.Parse(reader.GetAttribute("left"), cultures));
                    Con.Add(Int32.Parse(reader.GetAttribute("right"), cultures));
                }else if (reader.Name == "no")
                {
                    roomID = Int32.Parse(reader.GetAttribute("i"), cultures);
                }
                else if(reader.Name == "enemy" || reader.Name == "item" || reader.Name == "block" || reader.Name == "interior" || reader.Name == "exterior" || reader.Name == "wallCube" || reader.Name =="hud" || reader.Name == "src")
                {                   
                    int xpos = Int32.Parse(reader.GetAttribute("xpos"), cultures);
                    int ypos = Int32.Parse(reader.GetAttribute("ypos"), cultures);
                    String type = reader.GetAttribute("type");

                    switch (type)
                    {
                        case "HealthBar":
                            huds.Add(new HealthBar(xpos, ypos, link));
                            break;
                        case "WeaponSlot":
                            huds.Add(new WeaponSlot(xpos, ypos, link));
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
                        case "Compass":
                            items.Add(new Compass(xpos, ypos));
                            break;
                        case "Arrow":
                            items.Add(new Arrow(xpos, ypos));
                            break;
                        case "Bomb":
                            items.Add(new Bomb(xpos, ypos));
                            break;
                        case "Bow":
                            items.Add(new Bow(xpos, ypos));
                            break;
                        case "HeartContainer":
                            items.Add(new HeartContainer(xpos, ypos));
                            break;
                        case "Key":
                            items.Add(new Key(xpos, ypos));
                            break;
                        case "Map":
                            items.Add(new Map(xpos, ypos));
                            break;
                        case "Ruppy":
                            items.Add(new Ruppy(xpos, ypos));
                            break;
                        case "Triforce":
                            items.Add(new Triforce(xpos, ypos));
                            break;
                        case "WBoomerang":
                            items.Add(new WBoomerang(xpos, ypos));
                            break;
                        case "Merchant":
                            enemies.Add(new Merchant(xpos, ypos));
                            break;
                        case "Oldman":
                            enemies.Add(new Oldman(xpos, ypos));
                            break;
                        case "Dodongo":
                            enemies.Add(new Dodongo(xpos, ypos));
                            break;
                        case "Aqua":
                            enemies.Add(new Aqua(xpos, ypos));
                            break;
                        case "Rope":
                            enemies.Add(new Rope(xpos, ypos));
                            break;
                        case "Trap":
                            enemies.Add(new Trap(xpos, ypos));
                            break;
                        case "Wallmaster":
                            enemies.Add(new Wallmaster(xpos, ypos));
                            break;
                        case "Zol":
                            enemies.Add(new Zol(xpos, ypos));
                            break;
                        case "Goriya":
                            enemies.Add(new Goriya(xpos, ypos));
                            break;
                        case "Stalfos":
                            enemies.Add(new Stalfos(xpos, ypos));
                            break;
                        case "Keese":
                            enemies.Add(new Keese(xpos, ypos));
                            break;
                    }

                }
            }
            for (int i = 0; i < Con.Count; i++)
            {
                Console.WriteLine("ID: " + roomID);
                Console.WriteLine("Con" + i + ": " + Con[i]);

            }

            return new roomProperties(roomID, blocks, items, enemies, rooms, huds, cubes, link, source, Con);
        }
    }
}
