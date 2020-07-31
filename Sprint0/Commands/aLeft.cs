namespace Sprint0.Commands
{
    class aLeft : ICommand
    {
        private Game1 myGame;

        public aLeft(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.link.Left();
        }

    }
}
