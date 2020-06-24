using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Sprint0.Interfaces;
using Sprint0.Player;
using System.Windows;
using System.Xml;
using Sprint0.Enemies;
using Sprint0.Block;
using Sprint0.Items;
using Sprint0.Rooms;

namespace Sprint0.xml
{
    public class roomLoader
    {
        static public roomProperties LoadRoomFromXML(String filename)
        {
            roomProperties room = null;
           
            using (StreamReader stream = new StreamReader(filename))
            {
                stream.ReadLine(); //First line(useless) of the xml file
                room = LoadRoom(stream);
            }
            return room;
        }
        static private roomProperties LoadRoom(StreamReader stream)
        {
            List<IEnemy> enemies = new List<IEnemy>();
            List<IBlock> blocks = new List<IBlock>();
            List<IItem> items = new List<IItem>();
            List<IRoom> rooms = new List<IRoom>();
            Player1 link = null;
            
            String line;
            stream.ReadLine();//"<room>"
            while ((line = stream.ReadLine()) != null && !line.Equals("</room>"))
            {
                string[] currentText = line.Split(' ');
                Console.WriteLine("curentext 0" + currentText[0]); 
                if (currentText[0].Equals("<player"))
                {
                    int? xpos = null;
                    int? ypos = null;
                    for (int count = 1; count < currentText.Length; count++)
                    {
                        if (currentText[count].Substring(0, 5).Equals("xpos="))
                        {
                            xpos = Int32.Parse(currentText[count].Trim('"'));
                        }
                        else if (currentText[count].Substring(0, 5).Equals("ypos="))
                        {
                            ypos = Int32.Parse(currentText[count].Trim('"'));
                        }
                    }
                    link = new Player1(xpos.Value, ypos.Value, 48, 48);

                }else
                {
                    int? xpos = null;
                    int? ypos = null;
                    String type = "";
                    for (int count = 1; count < currentText.Length; count++)
                    {
                        String temp = currentText[count];
                        if (currentText[count].Length > 5)
                        {
                            if (currentText[count].Substring(0, 5).Equals("xpos="))
                            {
                                xpos = Int32.Parse(currentText[count].Substring(5).Trim('"'));
                            }
                            else if (currentText[count].Substring(0, 5).Equals("ypos="))
                            {
                                ypos = Int32.Parse(currentText[count].Substring(5).Trim('"'));
                            }
                            else if (currentText[count].Substring(0, 5).Equals("type="))
                            {
                                type = currentText[count].Substring(5).Trim('"');
                            }
                        }
                    }
                    switch (type.Trim('"'))
                    {
                        case "Moblin":
                            enemies.Add(new Moblin(xpos.Value, ypos.Value));
                            break;
                        case "Peahat":
                            enemies.Add(new Peahat(xpos.Value, ypos.Value));
                            break;
                        case "Tektite":
                            enemies.Add(new Tektite(xpos.Value, ypos.Value));
                            break;
                        case "BlockA":
                            blocks.Add(new BlockA(xpos.Value, ypos.Value));
                            break;
                        case "BlockB":
                            blocks.Add(new BlockB(xpos.Value, ypos.Value));
                            break;
                        case "BlockC":
                            blocks.Add(new BlockC(xpos.Value, ypos.Value));
                            break;
                        case "RoomBlock":
                            blocks.Add(new BlockB(xpos.Value, ypos.Value));
                            break;
                        case "RoomEnemy":
                            blocks.Add(new BlockC(xpos.Value, ypos.Value));
                            break;
                        case "RoomItem":
                            blocks.Add(new BlockC(xpos.Value, ypos.Value));
                            break;
                    }
                }

            }
            return new roomProperties(blocks, items, enemies, link);
        }
    }
}
