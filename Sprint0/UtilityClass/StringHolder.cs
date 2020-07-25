using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.UtilityClass;

namespace Sprint0.UtilityClass
{
    class StringHolder
    {
        // StringHolders for Block Folder
        public const string BlockType = "block";
        public const string LockType = "lock";  // Also used for LinkBlockCollision.cs
        public const string WaterType = "water";

        // StringHolders for Collisions Folder
        public const string WoodenSword = "WoodenSword";
        public const string Bomb = "bomb";

        // StringHolders for Commands Folder
        public const string NextRoom = "nextroom: ";
        public const string MinusOne = "-1";

        // StringHolders for GameStates Folder
        public const string Dungeon = "dungeon";
        public const string Pause = "pause";
        public const string GameOver = "game_over";

        public const string Attacking = "attacking";
        public const string ArrowShooting = "arrowShooting";
        public const string Booming = "booming";
        public const string BoomrangShooting = "boomrangShooting";
        public const string Winning = "winning";

        //StringHolders for HUD Folder
        public const string None = "None";
        //public const string WoodenSword = "WoodenSword";
        public const string WhiteSword = "WhiteSword";
        public const string MagicalSword = "MagicalSword";
        public const string MagicalRod = "MagicalRod";
        public const string Boomrang= "Boomrang";
        //public const string Attacking = "Attacking";

        //StringHolders for Projectile Folder
        public const string Arrow = "arrow";

        //StringHolders for sprites Folder
        public const string Link = "link";
        public const string Shoot = "shoot";
        public const string Item = "item";
        public const string Map = "Map";
        public const string Hud = "Hud";
        public const string Enemy = "enemy";
        public const string Enemy2 = "enemy2";
        public const string Boss = "boss";
        public const string NPC =  "npc";
        public const string Blocks = "Blocks";
        public const string Store = "Store";
        //StringHolders for xml Folder
        public const string Culture = "en-US";
        public const string XPos = "xpos";
        public const string YPos = "ypos";
        public const string Src = "src";
        public const string Connect = "connect";
        public const string Content = "Content";

        //StringHolders for Menu
        public const string Play = "PLAY FIRST LEVEL";
        public const string NightmareMode = "NIGHTMARE MODE";
        public const string Restart = "RESTART";
        public const string Instruction = "PRESS SPACE TO SELECT, PRESS M TO SWITCH OPTION";

    }
}
