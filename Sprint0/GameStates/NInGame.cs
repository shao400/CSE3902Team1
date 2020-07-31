using Sprint0.Interfaces;
using Microsoft.Xna.Framework;
using Sprint0.HUDs;
using Sprint0.UtilityClass;

namespace Sprint0.GameStates
{
    class NInGame : IGameState
    {
        Game1 myGame;
        private Hud myHud;
        int x = 0;
        int y = 0;

        public NInGame(Game1 game, Hud hud1)
        {
            myGame = game;
            myHud = hud1;
        }
        public void Draw()
        {
            myGame.NcurrentRoom.Draw();
            if (myGame.link.GetCurrentStatus() == StringHolder.Attacking) { myGame.link.getAttacking().Stab(); }
            if (myGame.link.GetCurrentStatus() == StringHolder.ArrowShooting) { myGame.link.getPlayerItem2().Shoot(); }
            if (myGame.link.GetCurrentStatus() == StringHolder.Booming) { myGame.link.getPlayerItem2().Shoot(); }
            if (myGame.link.GetCurrentStatus() == StringHolder.BoomrangShooting) { myGame.link.getPlayerItem2().Shoot(); }

            if (myGame.link.getPlayerItem1().IsExplode() == 0)
            {
                myGame.link.getPlayerItem1().Shoot();
            }
            else if (myGame.link.getPlayerItem1().IsExplode() == 1)
            {
                myGame.link.getPlayerItem1().Explode();
            }
            if (myGame.link.getPlayerItem2().IsExplode() == 0)
            {
                myGame.link.getPlayerItem2().Shoot();
            }
            else if (myGame.link.getPlayerItem2().IsExplode() == 1)
            {
                myGame.link.getPlayerItem2().Explode();
            }
            myGame.link.getSprite().Draw(new Vector2(myGame.link.xAxis, myGame.link.yAxis), myGame.link.isTakingDmg());
            for (int i = 0; i < myGame.NcurrentRoom.DoorList.Count; i++)
            {
                myGame.NcurrentRoom.DoorList[i].Draw();
            }
            myGame.link.GetFog().Draw();
            myHud.Draw(x, y);
        }

        public void Update()
        {
            myGame.link.Update();
            myGame.link.BlockCollisionTest(myGame.NcurrentRoom.blockList);
            myGame.link.ProjectileBlocksCollisionTest(myGame.NcurrentRoom.blockList);
            myGame.link.EnemyCollisionTest(myGame.NcurrentRoom.enemyList);
            myGame.link.ProjectileEnemiesCollisionTest(myGame.NcurrentRoom.enemyList);
            myGame.link.ItemCollisionTest(myGame.NcurrentRoom.itemList);
            myGame.link.NpcCollisionTest(myGame.NcurrentRoom.NPCList);
            myGame.NcurrentRoom.Update();
        }
        public void loadNextRoom(int nextRoom)
        {
            
        }

        public void NextOption()
        {

        }
        public void LastOption()
        {

        }

        public void Select()
        {

        }
    }
}
