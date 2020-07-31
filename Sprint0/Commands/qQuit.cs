namespace Sprint0.Commands
{
    class qQuit : ICommand
    {
        private Game1 myGame;

        public qQuit(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.Exit();
        }

    }
}
