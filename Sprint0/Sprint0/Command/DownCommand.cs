using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint0
{
    public class DownCommand : ICommand
    {
        IPlayer Iplayer;
        public DownCommand(IPlayer Iplayer)
        {
            this.Iplayer = Iplayer;
        }

        public void Execute()
        {
            Iplayer.Down();
        }
    }
}

