
namespace Sprint0.Interfaces
{
    public interface IGameState
    {
        void Draw();

        void Update();

        void loadNextRoom(int nextRoom);

        void NextOption();

        void LastOption();

        void Select();
    }
}
