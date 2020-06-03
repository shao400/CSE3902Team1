using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint0
{
    public class FirstItemCommand : ICommand
    {
        IPlayer Iplayer;
        public FirstItemCommand(IPlayer Iplayer)
        {
            this.Iplayer = Iplayer;
        }

        public void Execute()
        {
            Iplayer.UseFirstItem();
        }
    }
}

