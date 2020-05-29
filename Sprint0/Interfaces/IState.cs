using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Interfaces
{
    interface IState
    {
        ISprite currentSprite
        {
            get;
            set;
        }

        void Update();
    }
}
