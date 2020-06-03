using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint0
{
    public class SecondItemCommand : ICommand
    {
        IPlayer Iplayer;
        public SecondItemCommand(IPlayer Iplayer)
        {
            this.Iplayer = Iplayer;
        }

        public void Execute()
        {
            Iplayer.UseSecondItem();
        }
    }
}

