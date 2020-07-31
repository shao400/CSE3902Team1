namespace Sprint0.Commands
{
    class sDown : ICommand
    {
        private Game1 myGame;

        public sDown(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.link.Down();
        }

    }
}
