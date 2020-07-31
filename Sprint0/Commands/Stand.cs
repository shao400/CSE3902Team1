namespace Sprint0.Commands
{
    class Stand : ICommand
    {
        private Game1 myGame;

        public Stand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.link.Stand();
        }

    }
}
