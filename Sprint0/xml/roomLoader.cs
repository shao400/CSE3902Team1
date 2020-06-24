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
            Player1 link = null;
            
            String line;
            stream.ReadLine();//"<room>"
            while ((line = stream.ReadLine()) != null && !line.Equals("</room>"))
            {
                string[] currentText = line.Split(' ');

                if (currentText[0].Equals("<player"))
                {
                    int xPos = 0;
                    int yPos = 0;
                    for (int count = 1; count < currentText.Length; count++)
                    {
                        if (currentText[count].Substring(0,5).Equals("xPos="))
                            xPos = Int32.Parse(currentText[count].Trim('"'));
                        else if (currentText[count].Substring(0, 5).Equals("yPos="))
                            yPos = Int32.Parse(currentText[count].Trim('"'));
                    }
                    link = new Player1(xPos, yPos, 48, 48);
                }else
                {
                    int? xPos = null;
                    int? yPos = null;
                    String type = "";
                    for (int count = 1; count < currentText.Length; count++)
                    {
                        String temp = currentText[count];
                        if (currentText[count].Length > 5)
                        {
                            if (currentText[count].Substring(0, 5).Equals("xPos="))
                                xPos = Int32.Parse(currentText[count].Substring(5).Trim('"'));
                            else if (currentText[count].Substring(0, 5).Equals("yPos="))
                                yPos = Int32.Parse(currentText[count].Substring(5).Trim('"'));
                            else if (currentText[count].Substring(0, 5).Equals("type="))
                                type = currentText[count].Substring(5).Trim('"');
                        }
                    }
                    switch (type.Trim('"'))
                    {
                        case "Moblin":
                            enemies.Add(new Moblin(xPos.Value, yPos.Value));
                            break;
                        case "Peahat":
                            enemies.Add(new Peahat(xPos.Value, yPos.Value));
                            break;
                        case "Tektite":
                            enemies.Add(new Tektite(xPos.Value, yPos.Value));
                            break;
                        case "BlockA":
                            blocks.Add(new BlockA(xPos.Value, yPos.Value));
                            break;
                        case "BlockB":
                            blocks.Add(new BlockB(xPos.Value, yPos.Value));
                            break;
                        case "BlockC":
                            blocks.Add(new BlockC(xPos.Value, yPos.Value));
                            break;
                    }
                }

            }
            return new roomProperties(blocks, items, enemies, link);
        }
    }
}
