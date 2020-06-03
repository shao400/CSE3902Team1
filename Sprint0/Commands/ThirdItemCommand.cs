using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint0
{
    public class ThirdItemCommand : ICommand
    {
        IPlayer Iplayer;
        public ThirdItemCommand(IPlayer Iplayer)
        {
            this.Iplayer = Iplayer;
        }

        public void Execute()
        {
            Iplayer.UseThirdItem();
        }
    }
}

