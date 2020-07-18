using Microsoft.Xna.Framework;
using Sprint0.Collisions;
using Sprint0.Sprite;
using System;
using Sprint0.Projectile;
using System.Collections.Generic;
using Sprint0.Interfaces;
using System.Runtime.CompilerServices;

// Author: Lufei Ouyang
namespace Sprint0.Player
{
    public class Player1 : IPlayer
    {
        private enum facing
        {
            up, down, left, right
        }
        private enum weapon
        {
            None, WoodenSword, WhiteSword, MagicalSword, MagicalRod
        }
        private enum status
        {
            standing, walking, attacking, takingDmg, shooting, booming, arrowShooting,boomrangShooting
        }
        public int xAxis;
        public int yAxis;
        private int width;
        private int height;
        public ISprite currentSprite;
        private facing currentFacing;
        private LinkBlockCollision linkBlockCollision;
        private LinkItemCollision linkItemCollision;
        private LinkEnemyCollision linkEnemyCollision;
        private status currentStatus;
        public Inventory myInventory;
        private Boolean GetMap;
        private Boolean GetCompass;

        Game1 myGame;
        public Queue<IProjectile> projectiles;
        public IProjectile currentProjectile;
        private ProjectileCollision projectileCollision;
        private Sound sound;
        private int hp;
        private int MaxHealth;
        private int ruppyCount;
        public int bombCount;
        private int keyCount;
        public Boolean arrowCdDone;
        public Boolean shootCdDone;
        private Queue<string> currentWp;

        public Player1(int x, int y, int widthG, int heightG, Sound s, Game1 game) 
        {
            myGame = game;
            xAxis = x;
            yAxis = y;
            width = widthG;
            height = heightG;
            sound = s;
            MaxHealth = 2;
            hp = MaxHealth;
            ruppyCount = 100;
            bombCount = 0;
            keyCount = 0;
            GetMap = false;
            GetCompass = false;
            currentFacing = facing.right;
            currentProjectile = new WoodenSword(this, 2);
            currentStatus = status.standing;
            currentSprite = SpriteFactory.LinkNoneStandingRight;
            myInventory = new Inventory(this, game);
            currentWp = new Queue<string>();
            currentWp.Enqueue("WoodenSword");
            projectiles = new Queue<IProjectile>();
            projectiles.Enqueue(currentProjectile);
            linkBlockCollision = new LinkBlockCollision(this);
            linkItemCollision = new LinkItemCollision(this);
            linkEnemyCollision = new LinkEnemyCollision(this);
        }

        public bool isTakingDmg()
        {
            return currentStatus == status.takingDmg;
        }
        public ISprite getSprite()
        {
            return currentSprite;
        }
        public string GetCurrentStatus()
        {

            return currentStatus.ToString();
        }
        public string GetCurrentWeapon()
        {
            if (currentWp.Count!=0) {
                return currentWp.Peek();
            }
            else
            {
                return "None";
            }
        }

        public void PickBuyWeapon(String weaponGet)
        {
            currentWp.Enqueue(weaponGet);
            if (weaponGet == "WoodenSword") ruppyCount -= 20;
        }
        public IProjectile getPlayerItem()
        {
            return currentProjectile;
        }
        public void Update()
        {

            getPlayerItem().Update();
            if (currentStatus == status.walking && currentFacing == facing.left)
            {
                if(xAxis > 0)
                {
                    xAxis -= 5;
                }    
            }
            else if (currentFacing == facing.right && currentStatus == status.walking)
            {
                if (xAxis < 720)
                {
                    xAxis += 5;
                }
            }
            else if (currentFacing == facing.down && currentStatus == status.walking)
            {
                if (yAxis < 648)
                {
                    yAxis += 5;
                }                
            }
            else if (currentFacing == facing.up && currentStatus == status.walking)
            {
                if (yAxis > 168)
                {
                    yAxis -= 5;
                }                
            }
            currentSprite.Update();
            
            //border restrictions
            if (xAxis <= 0) 
            { 
                xAxis = 624;
                myGame.currentState = myGame.stateList[1];
                myGame.currentState.loadNextRoom(myGame.currentRoom.Connectors[2]);
            }
            else if (xAxis >= 720) 
            {
                xAxis = 96;
                myGame.currentState = myGame.stateList[1];
                myGame.currentState.loadNextRoom(myGame.currentRoom.Connectors[3]);
            }
            else if (yAxis <= 168)
            {
                yAxis = 552;
                myGame.currentState = myGame.stateList[1];
                myGame.currentState.loadNextRoom(myGame.currentRoom.Connectors[0]);

            }
            else if (yAxis >= 648)
            { 
                yAxis = 264;
                myGame.currentState = myGame.stateList[1];
                myGame.currentState.loadNextRoom(myGame.currentRoom.Connectors[1]);
            }
        }
        public void Draw()
        {
            
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle(xAxis, yAxis, width, height);
        }
        public void Right()
        {
            currentStatus = status.walking;
            currentFacing = facing.right;
            currentSprite = SpriteFactory.LinkNoneMovingRight;
        }
        public void Left()
        {
            currentStatus = status.walking;
            currentFacing = facing.left;
            currentSprite = SpriteFactory.LinkNoneMovingLeft;
        }
        public void Up()
        {
            currentStatus = status.walking;
            currentFacing = facing.up;
            currentSprite = SpriteFactory.LinkNoneMovingUp;
        }
        public void Down()
        {
            currentStatus = status.walking;
            currentFacing = facing.down;
            currentSprite = SpriteFactory.LinkNoneMovingDown;
        }
        public void Stand()
        {
            currentStatus = status.standing;
            if (currentFacing == facing.up) currentSprite = SpriteFactory.LinkNoneStandingUp;
            if (currentFacing == facing.down) currentSprite = SpriteFactory.LinkNoneStandingDown;
            if (currentFacing == facing.left) currentSprite = SpriteFactory.LinkNoneStandingLeft;   
            if (currentFacing == facing.right) currentSprite = SpriteFactory.LinkNoneStandingRight;                                       
        }
        public void Attack()
        {
            if (currentWp.Peek() == "WoodenSword") { 
            currentStatus = status.attacking;
            if (currentFacing == facing.up) { currentProjectile = new WoodenSword(this, 0); currentSprite = SpriteFactory.LinkUsingUp; }
            else if (currentFacing == facing.down) { currentProjectile = new WoodenSword(this, 1); currentSprite = SpriteFactory.LinkUsingDown; }
            else if (currentFacing == facing.right) { currentProjectile = new WoodenSword(this, 2); currentSprite = SpriteFactory.LinkUsingRight; }
            else if (currentFacing == facing.left) { currentProjectile = new WoodenSword(this, 3); currentSprite = SpriteFactory.LinkUsingLeft; }
            currentProjectile.Stab();
            sound.swordSlash();
        }
        }
        public void Shoot() 
        {
            sound.swordShoot();
            if (currentWp.Peek() =="WoodenSword") {
                if (currentFacing == facing.up) { currentProjectile = new WoodenSword(this, 0); currentSprite = SpriteFactory.LinkUsingUp; }
                else if (currentFacing == facing.down) { currentProjectile = new WoodenSword(this, 1); currentSprite = SpriteFactory.LinkUsingDown; }
                else if (currentFacing == facing.right) { currentProjectile = new WoodenSword(this, 2); currentSprite = SpriteFactory.LinkUsingRight; }
                else if (currentFacing == facing.left) { currentProjectile = new WoodenSword(this, 3); currentSprite = SpriteFactory.LinkUsingLeft; }
                currentProjectile.explo(0);
                currentProjectile.Shoot();
                currentWp.Dequeue();
            }
        }
        public void Bomb() {
            sound.bombDrop();
            currentStatus = status.booming;
            currentProjectile=new Bomb(this,0);
            currentProjectile.Shoot();
            if(bombCount>0) bombCount -= 1;
        }
        public void Arrow()
        {
                 sound.arrowAndBoomerang();
                currentStatus = status.arrowShooting;
                if (currentFacing == facing.up) { currentProjectile = new Arrow(this, 0); currentSprite = SpriteFactory.LinkUsingUp; }
                else if (currentFacing == facing.down) { currentProjectile = new Arrow(this, 1); currentSprite = SpriteFactory.LinkUsingDown; }
                else if (currentFacing == facing.right) { currentProjectile = new Arrow(this, 2); currentSprite = SpriteFactory.LinkUsingRight; }
                else if (currentFacing == facing.left) { currentProjectile = new Arrow(this, 3); currentSprite = SpriteFactory.LinkUsingLeft; }
                currentProjectile.explo(0);
                currentProjectile.Shoot();
        }
        public void Boomrang()
        {
            sound.arrowAndBoomerang();
            currentStatus = status.boomrangShooting;
            if (currentFacing == facing.up) { currentProjectile = new Boomrang(this, 0); currentSprite = SpriteFactory.LinkUsingUp; }
            else if (currentFacing == facing.down) { currentProjectile = new Boomrang(this, 1); currentSprite = SpriteFactory.LinkUsingDown; }
            else if (currentFacing == facing.right) { currentProjectile = new Boomrang(this, 2); currentSprite = SpriteFactory.LinkUsingRight; }
            else if (currentFacing == facing.left) { currentProjectile = new Boomrang(this, 3); currentSprite = SpriteFactory.LinkUsingLeft; }
            currentProjectile.explo(0);
            currentProjectile.Shoot();
        }

        public void takeDmg()
        {
            sound.linkHurt();
            currentStatus = status.takingDmg;
            if (hp>1)
            {
                hp--;
            }
            else
            {
                sound.linkDie();

                myGame.currentState = myGame.stateList[5];
            }
        }

        public void getHealed()
        {
            sound.getHeart();
            if (hp<MaxHealth)
            {
                
                hp++;
            }
        }

        public void increaseMaxHp()
        {
            sound.getHeart();
            const int HpBound = 6;
            if (MaxHealth<HpBound) {
                MaxHealth += 2;
            }
            hp = MaxHealth;
        }

        public void getRuppy()
        {
            sound.getRupee();
            if (ruppyCount<999)
            {
                ruppyCount++;
            }
        }

        public void getBomb()
        {
            sound.getItem();
            if (bombCount < 99)
            {
                bombCount++;
            }
        }
        public void getKey()
        {
            sound.getItem();
            if (keyCount < 99)
            {
                keyCount++;
            }
        }

        public int getKeyCount()
        {
            return keyCount;
        }

        public void useKey()
        {
            if (0 < keyCount)
            {
                keyCount--;
            }
        }

        public void unlockBothLocks()
        {
            int x = -1;
            int y = -1;
            switch (currentFacing)
            {
                case facing.up:
                    x = 357;
                    y = 615;
                    break;
                case facing.down:
                    x = 357;
                    y = 198;
                    break;
                case facing.left:
                    x = 696;
                    y = 384;
                    break;
                case facing.right:
                    x = 0;
                    y = 384;
                    break;
            }
            foreach (IBlock block in myGame.roomList[myGame.currentRoom.Connectors[getFacing()]].blockList)
            {
                if (block.GetType() == "lock")
                {
                    if (block.GetRectangle().X == x && block.GetRectangle().Y == y)
                    {
                        myGame.roomList[myGame.currentRoom.Connectors[getFacing()]].blockList.Remove(block);
                        sound.doorUnlock();
                        break;
                    }
                    
                }
            }
                
        }
        private int getFacing()
        {
            int rt = -1;
            switch (currentFacing)
            {
                case facing.up:
                    return 0;
                case facing.down:
                    return 1;
                case facing.left:
                    return 2;
                case facing.right:
                    return 3;
            }
            return rt;
        }

        public List<int> itemCount()
        {
            List<int> itemC = new List<int>();
            itemC.Add(ruppyCount);
            itemC.Add(keyCount);
            itemC.Add(bombCount);
            return itemC;
        }

        public void MapOrCompassGet(int MorC)
        {
            sound.getItem();
            if (MorC == 0) {
                GetMap = true;
            }else if (MorC ==1)
            {
                GetCompass = true;
            }
        }

        public List<Boolean> HaveMapOrCompass()
        {
            List<Boolean> HaveMorC = new List<Boolean>();
            HaveMorC.Add(GetMap);
            HaveMorC.Add(GetCompass);
            return HaveMorC;
        }

        public void winGame()
        {
            myGame.currentState = myGame.stateList[6];
        }


        public void PlayerReset()
        {
            this.currentFacing = facing.right;
            this.currentProjectile = new WoodenSword(this, 2);
            this.currentStatus = status.standing;
            this.currentSprite = SpriteFactory.LinkNoneStandingRight;
            xAxis = 100;
            yAxis = 100;
            ruppyCount = 0;
            keyCount = 0;
            bombCount = 0;
            hp = MaxHealth;
        }

        public int linkHp()
        {
            return hp;
        }

        public int linkMaxHp()
        {
            return MaxHealth;
        }
        public void UseFirstItem()
        {
            
        }
        public void UseSecondItem()
        {
            
        }
        public void UseThirdItem()
        {
           
        }
        public void UseFourthItem()
        {
           
        }
        public Sound GetSound()
        {
            return sound;
        }

        //collision tests
        public void BlockCollisionTest(List<IBlock> blocks)
        {
            linkBlockCollision.BlockCollision(blocks);
        }
        public void ProjectileBlocksCollisionTest(List<IBlock> blocks)
        {
            projectileCollision = new ProjectileCollision(currentProjectile);
            projectileCollision.ProjectileBlocksCollisionTest(blocks);
        }
        public void ProjectileEnemiesCollisionTest(List<IEnemy> enemies)
        {
            projectileCollision = new ProjectileCollision(currentProjectile);
            projectileCollision.ProjectileEnemiesCollisionTest(enemies, sound);
        }

        public void EnemyCollisionTest(List<IEnemy> enemies)
        {
            linkEnemyCollision.EnemyCollisionTest(enemies);
        }

        public void ItemCollisionTest(List<IItem> items)
        {
            linkItemCollision.ItemCollision(items);
        }
    }
}
