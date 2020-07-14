using Microsoft.Xna.Framework;
using Sprint0.Collisions;
using Sprint0.Sprite;
using System;
using Sprint0.Projectile;
using System.Collections.Generic;
using Sprint0.Interfaces;

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
            standing, walking, attacking, takingDmg, shooting, booming, arrowShooting
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

        Game1 myGame;
        private string currentStatus1;
        public IProjectile currentProjectile;
        private ProjectileCollision projectileCollision;
        int counter;
        private Sound sound;
        private int hp;

        public Player1(int x, int y, int widthG, int heightG, Sound s, Game1 game) 
        {
            myGame = game;
            xAxis = x;
            yAxis = y;
            width = widthG;
            height = heightG;
            sound = s;
            hp = 2;
            counter = 0;
            currentFacing = facing.right;
            currentProjectile = new WoodenSword(this, 2);
            currentStatus = status.standing;
            currentSprite = SpriteFactory.LinkNoneStandingRight;


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

            return currentProjectile.GetType().ToString();
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
            //states.Draw();
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

            if (currentFacing == facing.up)
            {
                currentSprite = SpriteFactory.LinkNoneStandingUp;
            }
            if (currentFacing == facing.down)
            {
                currentSprite = SpriteFactory.LinkNoneStandingDown;
            }
            if (currentFacing == facing.left)
            {
                currentSprite = SpriteFactory.LinkNoneStandingLeft;
            }
            if (currentFacing == facing.right)
            {
                currentSprite = SpriteFactory.LinkNoneStandingRight;
            }
        }
        public void Attack()
        {
            currentStatus = status.attacking;
            if (currentFacing == facing.up) currentProjectile = new WoodenSword(this, 0);
            else if (currentFacing == facing.down) currentProjectile = new WoodenSword(this, 1);
            else if (currentFacing == facing.right) currentProjectile = new WoodenSword(this, 2);
            else if (currentFacing == facing.left) currentProjectile = new WoodenSword(this, 3);
            currentProjectile.Stab();
            sound.swordSlash();
        }
        public void Shoot() {
            
            if (currentFacing == facing.up) currentProjectile = new WoodenSword(this, 0);
            else if (currentFacing == facing.down) currentProjectile = new WoodenSword(this, 1);
            else if (currentFacing == facing.right) currentProjectile = new WoodenSword(this, 2);
            else if (currentFacing == facing.left) currentProjectile = new WoodenSword(this, 3);
            currentProjectile.explo(0);
            currentProjectile.Shoot();

        }
        public void Bomb() {
            currentStatus = status.booming;
            currentProjectile=new Bomb(this,0);
            currentProjectile.Shoot();
        }
        public void Arrow()
        {
            currentStatus = status.arrowShooting;
            if (currentFacing == facing.up) currentProjectile = new Arrow(this, 0);
            else if (currentFacing == facing.down) currentProjectile = new Arrow(this, 1);
            else if (currentFacing == facing.right) currentProjectile = new Arrow(this, 2);
            else if (currentFacing == facing.left) currentProjectile = new Arrow(this, 3);
            currentProjectile.explo(0);
            currentProjectile.Shoot();

        }

        public void takeDmg()
        {
            sound.linkHurt();
            currentStatus = status.takingDmg;
            if (hp>0)
            {
                hp--;
            }
            else
            {
                myGame.currentState = myGame.stateList[5];
            }
        }

        public void getHealed()
        {
            if (hp<2)
            {
                hp++;
            }
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
            hp = 2;
        }

        public int linkHp()
        {
            return hp;
        }
        public void UseFirstItem()
        {
            sound.swordSlash();
        }
        public void UseSecondItem()
        {
            sound.swordSlash();
        }
        public void UseThirdItem()
        {
            sound.swordSlash();
        }
        public void UseFourthItem()
        {
            sound.magicRod();
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
            projectileCollision.ProjectileEnemiesCollisionTest(enemies);
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
