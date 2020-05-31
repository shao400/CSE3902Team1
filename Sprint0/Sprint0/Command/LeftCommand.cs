using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint0
{
    public class LeftCommand : ICommand
    {
        IPlayer Iplayer;
        public LeftCommand(IPlayer Iplayer)
        {
            this.Iplayer = Iplayer;
        }

        public void Execute()
        {
            Iplayer.Left();
        }
    }
}

