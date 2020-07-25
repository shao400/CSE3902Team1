using Microsoft.Xna.Framework;
using Sprint0.Collisions;
using Sprint0.Sprite;
using System;
using Sprint0.Projectile;
using System.Collections.Generic;
using Sprint0.Interfaces;
using System.Runtime.CompilerServices;
using Sprint0.UtilityClass;
using Sprint0.Inventories;
using Sprint0.GameStates;

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
            standing, walking, attacking, takingDmg, shooting, booming, arrowShooting, boomrangShooting
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
        private LinkNpcCollision linkNpcCollision;
        private status currentStatus;
        public Inventory myInventory;
        public StoreStock myStock;
        private Boolean GetMap;
        private Boolean GetCompass;
        public Fog myFog;

        Game1 myGame;
        public Queue<IProjectile> projectiles;
        public IProjectile currentProjectile, secondProjectile, currentAttack;
        private ProjectileCollision projectileCollision1, projectileCollision2, projectileCollision3;
        private Sound sound;
        private int hp, dmgCounter;
        public int MaxHealth;
        public int ruppyCount;
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
            MaxHealth = 6;
            hp = MaxHealth;
            ruppyCount = 100;
            bombCount = 0;
            keyCount = 50;
            GetMap = false;
            GetCompass = false;
            dmgCounter = 18;
            currentFacing = facing.right;
            currentProjectile = new WoodenSword(this, 2);
            currentAttack = new WoodenSword(this, 2);
            secondProjectile = new WoodenSword(this, 2);
            currentStatus = status.standing;
            currentSprite = SpriteFactory.LinkNoneStandingRight;
            myInventory = new Inventory(this);
            myStock = new StoreStock(this);
            currentWp = new Queue<string>();
            currentWp.Enqueue(StringHolder.WoodenSword);
            projectiles = new Queue<IProjectile>();
            projectiles.Enqueue(currentProjectile);
            linkBlockCollision = new LinkBlockCollision(this);
            linkItemCollision = new LinkItemCollision(this);
            linkEnemyCollision = new LinkEnemyCollision(this);
            linkNpcCollision = new LinkNpcCollision(this,myGame);
            myFog = new Fog(this);
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
            if (currentWp.Count != 0)
            {
                return currentWp.Peek();
            }
            else
            {
                return StringHolder.None;
            }
        }

        public void PickBuyWeapon(String weaponGet)
        {
            currentWp.Enqueue(weaponGet);
            if (weaponGet == StringHolder.WoodenSword) ruppyCount -= 20;
        }
        public IProjectile getPlayerItem1()
        {
            return currentProjectile;
        }
        public IProjectile getPlayerItem2()
        {
            return secondProjectile;
        }
        public IProjectile getAttacking()
        {
            return currentAttack;
        }

        public Fog GetFog() 
        {
            return myFog;
        }
        public void Update()
        {

            getPlayerItem1().Update();
            getPlayerItem2().Update();
            if (currentStatus == status.walking && currentFacing == facing.left)
            {
                if (xAxis > 0)
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
            if (dmgCounter < 18)
            {
                dmgCounter++;

            }
            myFog.Update();
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
            
                currentStatus = status.attacking;
                if (currentFacing == facing.up) { currentAttack = new WoodenSword(this, 0); currentSprite = SpriteFactory.LinkUsingUp; }
                else if (currentFacing == facing.down) { currentAttack = new WoodenSword(this, 1); currentSprite = SpriteFactory.LinkUsingDown; }
                else if (currentFacing == facing.right) { currentAttack = new WoodenSword(this, 2); currentSprite = SpriteFactory.LinkUsingRight; }
                else if (currentFacing == facing.left) { currentAttack = new WoodenSword(this, 3); currentSprite = SpriteFactory.LinkUsingLeft; }
                currentAttack.Stab();
                sound.swordSlash();


        }
        public void Shoot()
        {
            if (currentProjectile.IsExplode() == 2)
            {
                currentStatus = status.shooting;
                if (currentFacing == facing.up) { currentProjectile = new WoodenSword(this, 0); currentSprite = SpriteFactory.LinkUsingUp; }
                else if (currentFacing == facing.down) { currentProjectile = new WoodenSword(this, 1); currentSprite = SpriteFactory.LinkUsingDown; }
                else if (currentFacing == facing.right) { currentProjectile = new WoodenSword(this, 2); currentSprite = SpriteFactory.LinkUsingRight; }
                else if (currentFacing == facing.left) { currentProjectile = new WoodenSword(this, 3); currentSprite = SpriteFactory.LinkUsingLeft; }
                currentProjectile.setExplo(0);
                currentProjectile.Shoot();
                sound.swordShoot();
            }
            else { this.Attack(); }
            

        }
        public void Bomb()
        {
            if (secondProjectile.IsExplode() == 2)
            {
                sound.bombDrop();
                currentStatus = status.booming;
                secondProjectile = new Bomb(this);
                secondProjectile.Shoot();
                if (bombCount > 0) bombCount -= 1;
            }
        }
        public void Arrow()
        {
            if (secondProjectile.IsExplode() == 2)
            {
                sound.arrowAndBoomerang();
                currentStatus = status.arrowShooting;
                if (currentFacing == facing.up) { secondProjectile = new Arrow(this, 0); currentSprite = SpriteFactory.LinkUsingUp; }
                else if (currentFacing == facing.down) { secondProjectile = new Arrow(this, 1); currentSprite = SpriteFactory.LinkUsingDown; }
                else if (currentFacing == facing.right) { secondProjectile = new Arrow(this, 2); currentSprite = SpriteFactory.LinkUsingRight; }
                else if (currentFacing == facing.left) { secondProjectile = new Arrow(this, 3); currentSprite = SpriteFactory.LinkUsingLeft; }
                secondProjectile.setExplo(0);
                secondProjectile.Shoot();
            }
        }
        public void Boomrang()
        {
            if (secondProjectile.IsExplode() == 2)
            {
                sound.arrowAndBoomerang();
                currentStatus = status.boomrangShooting;
                if (currentFacing == facing.up) { secondProjectile = new Boomrang(this, 0); currentSprite = SpriteFactory.LinkUsingUp; }
                else if (currentFacing == facing.down) { secondProjectile = new Boomrang(this, 1); currentSprite = SpriteFactory.LinkUsingDown; }
                else if (currentFacing == facing.right) { secondProjectile = new Boomrang(this, 2); currentSprite = SpriteFactory.LinkUsingRight; }
                else if (currentFacing == facing.left) { secondProjectile = new Boomrang(this, 3); currentSprite = SpriteFactory.LinkUsingLeft; }
                secondProjectile.setExplo(0);
                secondProjectile.Shoot();
            }
        }

        public void takeDmg(int d)
        {
            if (dmgCounter == 18)
            {
                sound.linkHurt();
                currentStatus = status.takingDmg;
                if (hp > 0)
                {
                    hp-=d;
                    if (hp <= 0)
                    {
                        sound.pause();
                        sound.linkDie();
                        myGame.currentState = myGame.stateList[5];
                    }
                }

                dmgCounter = 0;
            }
            
        }

        public void getHealed()
        {
            sound.getHeart();
            if (hp < MaxHealth)
            {

                hp++;
            }
        }

        public void increaseMaxHp()
        {
            sound.getHeart();
            const int HpBound = 16;
            if (MaxHealth < HpBound)
            {
                MaxHealth += 2;
            }
            hp = MaxHealth;
        }
        public void getRuppy()
        {
            sound.getRupee();
            if (ruppyCount < 999)
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
                if (block.getType() == StringHolder.LockType)
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
            if (MorC == 0)
            {
                GetMap = true;
            }
            else if (MorC == 1)
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
            sound.getTriforce();
            sound.pause();
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
            projectileCollision1 = new ProjectileCollision(currentProjectile, this);
            projectileCollision1.ProjectileBlocksCollisionTest(blocks);
            projectileCollision2 = new ProjectileCollision(secondProjectile, this);
            projectileCollision2.ProjectileBlocksCollisionTest(blocks);
        }
        public void ProjectileEnemiesCollisionTest(List<IEnemy> enemies)
        {
            projectileCollision1 = new ProjectileCollision(currentProjectile, this);
            projectileCollision1.ProjectileEnemiesCollisionTest(enemies, sound);
            projectileCollision2 = new ProjectileCollision(secondProjectile, this);
            projectileCollision2.ProjectileEnemiesCollisionTest(enemies, sound);
            projectileCollision3 = new ProjectileCollision(currentAttack, this);
            projectileCollision3.ProjectileEnemiesCollisionTest(enemies, sound);
            currentAttack.setExplo(3);
        }

        public void ProjectileLinkCollisionTest(Sound s)
        {
            projectileCollision1 = new ProjectileCollision(currentProjectile, this);
            projectileCollision1.ProjectileLinkCollisionTest(sound);
            projectileCollision2 = new ProjectileCollision(secondProjectile, this);
            projectileCollision2.ProjectileLinkCollisionTest(sound);
            projectileCollision3 = new ProjectileCollision(secondProjectile, this);
            projectileCollision3.ProjectileLinkCollisionTest(sound);
        }

        public void EnemyCollisionTest(List<IEnemy> enemies)
        {
            linkEnemyCollision.EnemyCollisionTest(enemies, sound);
        }

        public void ItemCollisionTest(List<IItem> items)
        {
            linkItemCollision.ItemCollision(items, sound);
        }

        public void NpcCollisionTest(List<INPC> npcs)
        {
            linkNpcCollision.NpcCollision(npcs);                
        }
    }
}
