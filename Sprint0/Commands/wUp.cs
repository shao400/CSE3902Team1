namespace Sprint0.Commands
{
    class wUp : ICommand
    {
        private Game1 myGame;

        public wUp(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
                myGame.link.Up();
        }

    }
}
