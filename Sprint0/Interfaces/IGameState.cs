using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Interfaces
{
    public interface IGameState
    {
        void Draw();

        void Update();

        void loadNextRoom(int nextRoom);
    }
}
