using Sprint0.UtilityClass;

namespace Sprint0.Commands
{
    class mSwitchOption : ICommand
    {
        private Game1 myGame;

        public mSwitchOption(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            if (myGame.currentState == myGame.stateList[IntegerHolder.Seven])
                myGame.currentState.NextOption();
        }
    }
}
