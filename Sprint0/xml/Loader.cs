using System;
using System.Collections.Generic;
using System.Xml;
using Sprint0.Player;
using Sprint0.Enemies;
using Sprint0.Block;
using Sprint0.Items;
using Sprint0.Interfaces;
using Sprint0.HUDs;
using Sprint0.NPCs;
using System.Globalization;
using Microsoft.Xna.Framework;
using Sprint0.UtilityClass;
using System.Runtime.CompilerServices;

// Author: Chuwen Sun
namespace Sprint0.xml
{
    public static class Loader
    {
        static public roomProperties LoadFromReader(XmlReader reader, Game1 game)
        {
            int roomID = -1;
            List<IEnemy> enemies = new List<IEnemy>();
            List<IBlock> blocks = new List<IBlock>();
            List<IItem> items = new List<IItem>();
            List<IDoor> doors = new List<IDoor>();
            List<INPC> NPCs = new List<INPC>();
            reader.MoveToContent();
            reader.Read(); // jump over <Room>
            CultureInfo cultures = new CultureInfo(StringHolder.Culture);
            Rectangle source = new Rectangle(0,0,0,0);
            List<int> Con = new List<int>();
            while (reader.Read())
            {   
                if (reader.Name == StringHolder.Src)
                {
                    source = new Rectangle(Int32.Parse(reader.GetAttribute(StringHolder.XPos), cultures), Int32.Parse(reader.GetAttribute(StringHolder.YPos), cultures), 256, 176);
                }else if (reader.Name == StringHolder.Connect)
                {
                    Con.Add(Int32.Parse(reader.GetAttribute("up"), cultures));
                    Con.Add(Int32.Parse(reader.GetAttribute("down"), cultures));
                    Con.Add(Int32.Parse(reader.GetAttribute("left"), cultures));
                    Con.Add(Int32.Parse(reader.GetAttribute("right"), cultures));
                }else if (reader.Name == "no")
                {
                    roomID = Int32.Parse(reader.GetAttribute("i"), cultures);
                }
                else if(reader.Name == "enemy" || reader.Name == "door" || reader.Name == "item" || reader.Name == "block" || reader.Name == StringHolder.Src || reader.Name == "NPC")
                {                   
                    int xpos = Int32.Parse(reader.GetAttribute("xpos"), cultures);
                    int ypos = Int32.Parse(reader.GetAttribute("ypos"), cultures);
                    String type = reader.GetAttribute("type");

                    switch (type)
                    {
                        case "Empty":
                            enemies.Add(new Empty(xpos, ypos));
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
                        case "BlockX":
                            blocks.Add(new BlockX(xpos, ypos));
                            break;
                        case "BlockY":
                            blocks.Add(new BlockY(xpos, ypos));
                            break;
                        case "BlockTop":
                            blocks.Add(new BlockTop(xpos, ypos));
                            break;
                        case "BlockLeft":
                            blocks.Add(new BlockLeft(xpos, ypos));
                            break;
                        case "BlockAllLeft":
                            blocks.Add(new BlockAllLeft(xpos, ypos));
                            break;
                        case "BlockAllTop":
                            blocks.Add(new BlockAllTop(xpos, ypos));
                            break;
                        case "BlockC":
                            blocks.Add(new BlockC(xpos, ypos));
                            break;
                        case "Water":
                            blocks.Add(new Water(xpos, ypos));
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
                        case "WoodenSword":
                            items.Add(new WoodenSwordItem(xpos, ypos));
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
                        case "Boomerang":
                            items.Add(new Boomerang(xpos, ypos));
                            break;
                        case "Merchant":
                            NPCs.Add(new Merchant(xpos, ypos));
                            break;
                        case "Flame":
                            NPCs.Add(new Flame(xpos, ypos));
                            break;
                        case "Oldman":
                            enemies.Add(new Oldman(xpos, ypos, game.link));
                            break;
                        case "Dodongo":
                            enemies.Add(new Dodongo(xpos, ypos));
                            break;
                        case "Aqua":
                            enemies.Add(new Aqua(xpos, ypos, game.link));
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
                        case "Gel":
                            enemies.Add(new Gel(xpos, ypos));
                            break;
                        case "DoorKLeft":
                            doors.Add(new DoorKLeft(xpos, ypos));
                            blocks.Add(new Lock(IntegerHolder.FoutyFive, 384));
                            doors.Add(new KeyholeLeft(0, 384));
                            break;
                        case "DoorKUp":
                            doors.Add(new DoorKUp(xpos, ypos));
                            blocks.Add(new Lock(357, 212));
                            doors.Add(new KeyholeUp(336, IntegerHolder.OneSixEight));
                            break;
                        case "DoorKDown":
                            doors.Add(new DoorKDown(xpos, ypos));
                            blocks.Add(new Lock(357, 596));
                            doors.Add(new KeyholeDown(336, 600));
                            break;
                        case "DoorKRight":
                            doors.Add(new DoorKRight(xpos, ypos));
                            blocks.Add(new Lock(675, 384));
                            doors.Add(new KeyholeRight(672, 384));
                            break;
                        case "DoorBUp":
                            doors.Add(new DoorBUp(xpos, ypos));
                            break;
                        case "DoorBDown":
                            doors.Add(new DoorBDown(xpos, ypos));
                            break;
                    }

                }
            }

            return new roomProperties(roomID, blocks, items, enemies, source, Con, doors, NPCs);
        }
    }
}
