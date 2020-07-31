namespace Sprint0.Commands
{
    class rReset : ICommand
    {
        private Game1 myGame;

        public rReset(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.Reset();
        }

    }
}
