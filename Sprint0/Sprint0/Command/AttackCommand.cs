using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint0
{
    public class AttackCommand : ICommand
    {
        IPlayer Iplayer;
        public AttackCommand(IPlayer Iplayer)
        {
            this.Iplayer = Iplayer;
        }

        public void Execute()
        {
            Iplayer.Attack();
        }
    }
}

