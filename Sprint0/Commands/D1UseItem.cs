using Sprint0.UtilityClass;

namespace Sprint0.Commands
{
    class D1UseItem : ICommand
    {
        private Game1 myGame;

        public D1UseItem(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            if (myGame.link.myInventory.currentItem == 1)
            {
                if (myGame.link.itemCount()[2] > 0)
                {
                    myGame.link.Bomb();
                }
            }
            else if (myGame.link.myInventory.currentItem == 2)
            {
                myGame.link.Arrow();
            }
            else if (myGame.link.myInventory.currentItem == IntegerHolder.Three)
            {
                myGame.link.Boomrang();
            }
        }
    }
}
